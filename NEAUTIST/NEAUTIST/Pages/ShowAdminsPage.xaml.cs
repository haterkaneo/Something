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
using NEAUTIST.Models;

namespace NEAUTIST.Pages
{
    /// <summary>
    /// Логика взаимодействия для ShowAdminsPage.xaml
    /// </summary>
    public partial class ShowAdminsPage : Page
    {
        public ShowAdminsPage()
        {
            InitializeComponent();
            DGAdminList.ItemsSource = App.DB.User.Where(x => x.RoleId == 1).ToList();
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
