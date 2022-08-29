using StandupIndicators.DesktopApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StandupIndicators.DesktopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DbChangeClick(object sender, RoutedEventArgs e)
        {
            DbAssignment db = new DbAssignment();
            db.AssignDbPath();
        }

        private void AppSettingsClick(object sender, RoutedEventArgs e)
        {
            Content.Content = new View.Settings_Departament();
        }

        private void MeetingClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
