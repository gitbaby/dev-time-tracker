using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace DevTimeTracker
{
    internal static class Program
    {
        private const string _title = "Active Time Tracker";

        private static SessionSwitchReason[] unlockedReasons;
        private static SessionSwitchReason[] lockedReasons;
        private static bool _isManuallySuspended;
        private static bool _isRunning;
        private static System.Timers.Timer _timer;
        private static DateTime _time;
        private static DateTime _nextReset;
        private static Menus _menus;
        private static Notification _notification;
        private static frmSettings _frmSettings;

        private static System.Drawing.Icon GetNotificationIcon
        {
            get => _isRunning ? Properties.Resources.systray : Properties.Resources.systray_inactive;
        }
        private static string GetTooltipTitle
        {
            get => _isRunning ? Notification.GetOnActiveContent(GetTime) : Notification.GetOnSuspendedContent(GetTime);
        }
        private static string GetTime
        {
            get => _time.ToTimeFormat();
        }
        private static bool IsDailyResetNeeded
        {
            get => Properties.Settings.Default.ResetDailyEnabled && DateTime.Now > _nextReset;
        }

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Process.GetProcessesByName(typeof(Program).Assembly.GetName().Name).Count() > 1) return;

            var notifyThread = new Thread(
                delegate ()
                {
                    CreateMenu();
                    CreateIcon();
                    CreateTimer();
                    SetNextReset();
                    BindToLockScreen();
                    BindToPowerMode();
                    BindToSessionEnding();

                    Application.Run();
                }
            );

            notifyThread.Start();
        }

        private static void CreateTimer()
        {
            _timer = new System.Timers.Timer()
            {
                AutoReset = true,
                Interval = 1000
            };

            _timer.Elapsed += new ElapsedEventHandler(OnTimerElapsed);

            if (Properties.Settings.Default.AutoStart)
            {
                _timer.Start();
            }

            MenuAndIconVisibility();
        }

        private static void SetNextReset()
        {
            var now = DateTime.Now;
            var diffHours = Properties.Settings.Default.ResetDailyAtHour - now.Hour;
            _nextReset = now.AddHours(diffHours).AddMinutes(-now.Minute).AddSeconds(-now.Second);
            if (diffHours < 0)
            {
                _nextReset = _nextReset.AddDays(1);
            }
        }

        private static void ResetTime(bool manual = false)
        {
            if (!manual)
            {
                _notification.ShowNotificationBalloon(Notification.GetOnResetContent());
                ValidFormInstance();
                SaveLastShift();
                SetNextReset();
            }

            _time = new DateTime();
            DisplayTime();
        }

        private static void SaveLastShift()
        {
            _frmSettings.SaveLastShift(_time);
        }

        private static void CreateMenu()
        {
            var menusDictionary = new Dictionary<MenuEnum, EventHandler>()
            {
                { MenuEnum.Suspend, new EventHandler(OnMenuSuspendClick) },
                { MenuEnum.Resume, new EventHandler(OnMenuResumeClick) },
                { MenuEnum.Reset, new EventHandler(OnMenuResetClick) },
                { MenuEnum.Settings, new EventHandler(OnMenuSettingsClick) },
                { MenuEnum.Exit, new EventHandler(OnMenuExitClick) },
            };

            _menus = new Menus(menusDictionary);
        }

        private static void CreateIcon()
        {
            _notification = new Notification(_menus.Menu, OnNotificationIconClick, _title);
        }

        private static void AddTime()
        {
            if (!_isRunning) return;
            _time = _time.AddSeconds(1);
        }

        private static void DisplayTime()
        {
            _notification.NotificationIcon.Text = GetTooltipTitle;
        }

        private static void CheckUserActivity()
        {
            if (_isManuallySuspended || !Properties.Settings.Default.AfkEnabled) return;

            var lastActivityLogMilliseconds = NativeMethods.GetIdleTime();
            if (lastActivityLogMilliseconds > Properties.Settings.Default.AfkDelayMilliseconds)
            {
                if (Suspend())
                {
                    _notification.ShowNotificationBalloon(Notification.GetOnUserInactive());
                }
            }
            else
            {
                if (Resume())
                {
                    if (_time.Minute > 0) _notification.ShowNotificationBalloon(Notification.GetOnUserActive());
                }
            }
        }

        private static bool Suspend(bool manual = false)
        {
            if (!_isRunning) return false;
            if (manual) _isManuallySuspended = true;
            _isRunning = false;
            MenuAndIconVisibility();
            return true;
        }

        private static bool Resume(bool manual = false)
        {
            if (_isRunning) return false;
            if (_isManuallySuspended)
            {
                if (!manual) return false;
                _isManuallySuspended = false;
            }
            _isRunning = true;
            MenuAndIconVisibility();
            return true;
        }

        private static void MenuAndIconVisibility()
        {
            _menus.GetSuspendMenu.Visible = _isRunning;
            _menus.GetResumeMenu.Visible = !_isRunning;
            _notification.NotificationIcon.Icon = GetNotificationIcon;
        }

        private static void ValidFormInstance()
        {
            if (_frmSettings == null)
            {
                _frmSettings = new frmSettings();
                _frmSettings.Left = Screen.PrimaryScreen.WorkingArea.Right - _frmSettings.Width;
                _frmSettings.Top = Screen.PrimaryScreen.WorkingArea.Bottom - _frmSettings.Height;
                _frmSettings.FormClosed += delegate { _frmSettings = null; };
            }
        }

        private static void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
        {
            if (!Properties.Settings.Default.LockScreenEnabled) return;

            if (lockedReasons.Contains(e.Reason))
            {
                Suspend();
            }
            else if (unlockedReasons.Contains(e.Reason))
            {
                Resume();

                if (IsDailyResetNeeded)
                {
                    ResetTime();
                }
            }
        }

        private static void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e)
        {
            if (!Properties.Settings.Default.AfkEnabled) return;

            if (e.Mode == PowerModes.Suspend)
            {
                Suspend();
            }
            else if (e.Mode == PowerModes.Resume)
            {
                Resume();

                if (IsDailyResetNeeded)
                {
                    ResetTime();
                }
            }
        }

        private static void SystemEvents_SessionEnding(object sender, SessionEndingEventArgs e)
        {
            SaveLastShift();
            ResetTime();
        }

        private static void OnTimerElapsed(object sender, EventArgs e)
        {
            AddTime();
            DisplayTime();

            if (_time.Second == 0)
            {
                CheckUserActivity();
            }
        }

        private static void OnNotificationIconClick(object sender, EventArgs e)
        {
            if (((MouseEventArgs)e).Button != MouseButtons.Left) return;
            if (_isRunning)
            {
                Suspend(true);
            }
            else
            {
                Resume(true);
            }
        }

        #region Menu Click Handlers
        private static void OnMenuExitClick(object sender, EventArgs e)
        {
            ValidFormInstance();
            SaveLastShift();

            _notification.Dispose();
            Application.Exit();
        }

        private static void OnMenuSettingsClick(object sender, EventArgs e)
        {
            ValidFormInstance();
            _frmSettings.Show();
        }

        private static void OnMenuResetClick(object sender, EventArgs e)
        {
            ResetTime(true);
        }

        private static void OnMenuSuspendClick(object sender, EventArgs e)
        {
            Suspend(true);
        }

        private static void OnMenuResumeClick(object sender, EventArgs e)
        {
            Resume(true);
        }
        #endregion

        #region System Events Binder
        private static void BindToLockScreen()
        {
            SystemEvents.SessionSwitch += new SessionSwitchEventHandler(SystemEvents_SessionSwitch);
            unlockedReasons = new[] { SessionSwitchReason.ConsoleConnect, SessionSwitchReason.RemoteConnect, SessionSwitchReason.SessionLogon, SessionSwitchReason.SessionUnlock };
            lockedReasons = new[] { SessionSwitchReason.ConsoleDisconnect, SessionSwitchReason.RemoteDisconnect, SessionSwitchReason.SessionLogoff, SessionSwitchReason.SessionLock };
        }

        private static void BindToPowerMode()
        {
            SystemEvents.PowerModeChanged += new PowerModeChangedEventHandler(SystemEvents_PowerModeChanged);
        }

        private static void BindToSessionEnding()
        {
            SystemEvents.SessionEnding += new SessionEndingEventHandler(SystemEvents_SessionEnding);
        }
        #endregion
    }
}