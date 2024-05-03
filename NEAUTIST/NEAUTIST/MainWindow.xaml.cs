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
using NEAUTIST.Pages;
using NEAUTIST.Models;
using System.Windows.Interop;


namespace NEAUTIST
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow Instance;
        public MainWindow()
        {
            InitializeComponent();
            Instance = this;
            DataContext = App.LoggedUser;
            MainFrame.Navigate(new LoginPage());
            var q = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            
            
            var image = q.Encode($"https://s.yimg.com/ny/api/res/1.2/ujhbKBvPoRp72zKNdLrREg--/YXBwaWQ9aGlnaGxhbmRlcjt3PTY0MDtoPTQ4MA--/https://media.zenfs.com/en/insider_articles_922/c6ce8d0b9a7b28f9c2dee8171da98b8f", Encoding.UTF8);
            QRCode.Source = Imaging.CreateBitmapSourceFromHBitmap(image.GetHbitmap(),
                            IntPtr.Zero,
                            Int32Rect.Empty,
                            BitmapSizeOptions.FromEmptyOptions());


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
        }
    }
}
