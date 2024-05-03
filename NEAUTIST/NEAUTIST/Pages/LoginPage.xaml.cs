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
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        User contextUser;
        public LoginPage()
        {
            InitializeComponent();
            contextUser = new User();
            
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            var loggedUser = App.DB.User.FirstOrDefault(x => x.Name == TBName.Text && x.Password == TBPassword.Text && x.SecretWord == TBSecretWord.Text);
            if (loggedUser == null)
            {
                MessageBox.Show("Неверный: логин // пароль // секретное слово");
                return;
            }

            App.LoggedUser = loggedUser;
            MainWindow.Instance.TBUser.Text = loggedUser.Role.Name + " " + loggedUser.Name;
            if (loggedUser.RoleId == 1)
            {
                NavigationService.Navigate(new AdminPage());
            }
            if (loggedUser.RoleId == 2)
            {
                NavigationService.Navigate(new UserPage());
            }
               
            
        }
    }
}
