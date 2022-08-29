using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace StandupIndicators.DesktopApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var settings = new Settings();
            var startup = new ViewModel.DbAssignment();
            startup.AssignDbPath(settings.DbPath);
        }
    }
}
