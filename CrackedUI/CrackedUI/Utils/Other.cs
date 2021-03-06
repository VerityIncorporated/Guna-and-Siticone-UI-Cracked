using System.IO;

namespace CrackedUI.Utils
{
    public static class Other
    {
        public enum IdeType
        {
            Rider,
            Vs
        }

        public enum ToastType
        {
            Notification,
            ButtonNotification
        }

        public static readonly string LogPath = $@"{Directory.GetCurrentDirectory()}\Logs\Log.txt";
        public static readonly string LogDirectory = $@"{Directory.GetCurrentDirectory()}\Logs\";
    }
}