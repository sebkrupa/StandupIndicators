using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace StandupIndicators.DesktopApp.View
{
    /// <summary>
    /// Interaction logic for Settings_Departament.xaml
    /// </summary>
    public partial class Settings_Departament : UserControl
    {
        public DB.DepartamentLogic DepartamentLogic { get; set; } = new DB.DepartamentLogic();
        public ObservableCollection<Model.Departament> Departaments { get; set; } = new ObservableCollection<Model.Departament>();
        public Settings_Departament()
        {
            InitializeComponent();
            PopulateDepartaments();
        }

        public void PopulateDepartaments()
        {
            var deps = DepartamentLogic.GetDepartaments();
            Departaments.Clear();
            foreach (var dep in deps)
            {
                Departaments.Add(dep);
            }
            dgDepartaments.
        }

        private async void  ButtonAdv_Click(object sender, RoutedEventArgs e)
        {
            var result = await DepartamentLogic.AddDepartament(txtName.Text.Trim());
            if(result == DB.Enums.StatusEnum.OK)
            {
                PopulateDepartaments();
                ClearInput();
            }
        }

        private void ClearInput()
        {
            txtName.Text = string.Empty;
        }
    }
}
