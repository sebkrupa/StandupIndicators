using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace StandupIndicators.DesktopApp.ViewModel
{
    public class OnAppStartup
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

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Pliki bazy danych SQLite (*.db;*.sqlite;*.sqlite3;*.db3)|*.db;*.sqlite;*.sqlite3;*.db3";
            dialog.FilterIndex = 1;
            dialog.Multiselect = false;
            
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
