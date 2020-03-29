using System;
using System.Windows.Forms;

namespace DevTimeTracker
{
    internal class Notification
    {
        internal NotifyIcon NotificationIcon { get; private set; }
        private static string GetLastShift => new DateTime().AddTicks(Properties.Settings.Default.LastShiftTicks).ToTimeFormat();

        internal Notification(ContextMenu menu, EventHandler mouseClick, string title)
        {
            NotificationIcon = new NotifyIcon
            {
                Icon = Properties.Resources.systray,
                ContextMenu = menu,
                Text = title,
                Visible = true,
                BalloonTipTitle = title,
            };
            NotificationIcon.Click += mouseClick;
        }

        internal void ShowNotificationBalloon(string content)
        {
            if (!Properties.Settings.Default.ShowNotifications) return;
            NotificationIcon.BalloonTipText = content;
            NotificationIcon.ShowBalloonTip(3000);
        }

        internal void Dispose()
        {
            NotificationIcon.Visible = false;
            NotificationIcon.Dispose();
        }

        internal static string GetOnActiveContent(string currentTime)
        {
            var currently = $"Logged: {currentTime}";
            var lastShift = $"Last time: {GetLastShift}";
            return $"{currently}\n{lastShift}\nClick to suspend.";
        }

        internal static string GetOnSuspendedContent(string currentTime)
        {
            var currently = $"Suspended on {currentTime}";
            return $"{currently}\nClick to resume.";
        }

        internal static string GetOnResetContent()
        {
            return "Time has been reset.";
        }

        internal static string GetOnUserInactive()
        {
            return "Suspended due to inactivity.";
        }

        internal static string GetOnUserActive()
        {
            return "Detected activity. Resuming...";
        }
    }
}
