using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;
using System.Windows;

namespace StandupIndicators.DesktopApp.ViewModel
{
    public class DbAssignment
    {
        private Settings Settings { get; set; } = new Settings();
        private bool DbVerified(string path)
        {
            if(string.IsNullOrEmpty(path))
                return false;
            return File.Exists(path);
        }
        public void AssignDbPath(string? path = null)
        {
            if(string.IsNullOrEmpty(path))
                AssignDbPath(AskUserForNewDbLocation());
            else
            {
                if (!DbVerified(path))
                    AssignDbPath();
                else
                    AssignPathToDbContext(path);
            }

        }

        private string AskUserForNewDbLocation()
        {
            string path = string.Empty;
            MessageBox.Show("W kolejnym kroku zostaniesz poproszony o wskazanie bazy danych." +
                "\nJeżeli robisz to po raz pierwszy, baza danych znajduje się w tym samym folderze co aplikacja i zawiera rozszerzenie '.db'." +
                "\nBazę danych można przenieść w dowolne inne miejsce (np udział sieciowy)." +
                "\nZalecane jest regularne wykonywanie kopii zapasowej bazy danych aby utrzymać integralność danych.",
                "Zmiana lokalizacji bazy danych",
                MessageBoxButton.OK,
                MessageBoxImage.Information);

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Pliki bazy danych SQLite (*.db;*.sqlite;*.sqlite3;*.db3)|*.db;*.sqlite;*.sqlite3;*.db3";
            dialog.FilterIndex = 1;
            dialog.Multiselect = false;
            dialog.Title = "Wybór bazy danych";
            
            if (dialog.ShowDialog() == true)
                path = dialog.FileName;
            else
                path = string.Empty;

            Settings.DbPath = path;
            Settings.Save();
            return path;
        }

        private void AssignPathToDbContext(string path)
        {
            DB.StandupDbContext.DbPath = path;
        }
    }
}
