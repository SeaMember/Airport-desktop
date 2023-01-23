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
using System.Collections;

namespace Airport_desktop.Pages_BuyWindow
{
    /// <summary>
    /// Логика взаимодействия для pgRoute.xaml
    /// </summary>
    public partial class pgRoute : Page
    {

        public pgRoute()
        {
            InitializeComponent();
            cbxcity();
        }

        private void cbxcity()
        {
            string[] text = System.IO.File.ReadAllLines(@"City.txt");
            for (int i = 0; i < text.GetLength(0); i++)

            {
                cbxStart.Items.Add(text[i]);

                cbxEnd.Items.Add(text[i]);

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(cbxStart.Text != cbxEnd.Text )
            {
                if( cbxStart.Text != "" && cbxStart.Text != null &&
                      cbxEnd.Text != "" && cbxEnd.Text != null)
                { 
                    Classes.Information.cbxStart = cbxStart;
                    Classes.Information.cbxEnd = cbxEnd;

                }

                else
                {
                    MessageBox.Show("Выберите один из городов в списке");
                }
            }

            else
            {
                MessageBox.Show("Города не должны совпадать");
            }
        }
    }
}
