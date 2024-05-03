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

namespace NEAUTIST.Pages
{
    /// <summary>
    /// Логика взаимодействия для ShowUsersPage.xaml
    /// </summary>
    public partial class ShowUsersPage : Page
    {
        public ShowUsersPage()
        {
            InitializeComponent();
            DGUserList.ItemsSource = App.DB.User.Where(x => x.RoleId == 2).ToList();
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
