using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using NEAUTIST.Models;

namespace NEAUTIST
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ExamNagimovEntities DB = new ExamNagimovEntities();
        public static User LoggedUser;
    }
}
