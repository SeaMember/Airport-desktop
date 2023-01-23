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
using System.IO;
using Microsoft.Data.Sqlite;

namespace Airport_desktop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void BtnLogIn_Click(object sender, RoutedEventArgs e)
        {
            if (pbPassword.Visibility == Visibility.Collapsed)
            {
                tbPassword.Text = pbPassword.Password;
                Classes.auth.Authe(tbLogin, pbPassword, this);
            }
            Classes.auth.Authe(tbLogin, pbPassword, this);
        }

        private void cbCheckPassword_Checked(object sender, EventArgs e)
        {
            tbPassword.Text = pbPassword.Password;
            pbPassword.Visibility = Visibility.Collapsed;
            tbPassword.Visibility = Visibility.Visible;
        }

        private void cbCheckPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            pbPassword.Password = tbPassword.Text;
            tbPassword.Visibility = Visibility.Collapsed;
            pbPassword.Visibility = Visibility.Visible;


        }
    }
}
