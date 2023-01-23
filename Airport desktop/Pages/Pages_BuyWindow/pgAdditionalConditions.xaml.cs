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

namespace Airport_desktop.Pages_BuyWindow
{
    /// <summary>
    /// Логика взаимодействия для pgAdditionalConditions.xaml
    /// </summary>
    public partial class pgAdditionalConditions : Page
    {
        private double _totalCost = 0;
        public pgAdditionalConditions()
        {
            InitializeComponent();

            TotalCostTextBox.Text = _totalCost.ToString() + " руб.";
        }
        
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null && checkBox.Tag != null)
            {
                double cost = double.Parse(checkBox.Tag.ToString());
                _totalCost += cost;
                TotalCostTextBox.Text = _totalCost.ToString() + " руб.";
            }
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null && checkBox.Tag != null)
            {
                double cost = double.Parse(checkBox.Tag.ToString());
                _totalCost -= cost;
                TotalCostTextBox.Text = _totalCost.ToString() + " руб.";
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            classNavigation.MainFrame.GoBack();
        }
    }
}
