using System.Windows.Forms;

namespace SmartTaskbar.Tray
{
    internal class TaskbarTray
    {
        private readonly NotifyIcon _notifyIcon;

        public TaskbarTray()
        {
            _notifyIcon = new NotifyIcon
            {
                Text = Application.ProductName,
                Icon = Properties.Resources.logo_32,
                Visible = true
            };

        }
    }
}
