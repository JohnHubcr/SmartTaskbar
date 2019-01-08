using SmartTaskbar.Tray;
using System.Threading;
using System.Windows;

namespace SmartTaskbar
{
    public partial class App : Application
    {
        private static TaskbarTray _tray;
        private static Mutex _mutex;


        protected override void OnStartup(StartupEventArgs e)
        {
            //Use a mutex to ensure single instance
            _mutex = new Mutex(true, "{959d3545-aa5c-42a8-a327-6e2c079daa94}", out bool createNew);

            if (!createNew)
            {
                Current.Shutdown();
                return;
            }

            _tray = new TaskbarTray();

            base.OnStartup(e);
        }
    }
}
