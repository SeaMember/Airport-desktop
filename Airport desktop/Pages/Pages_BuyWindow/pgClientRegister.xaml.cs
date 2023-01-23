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

namespace Airport_desktop.Pages.Pages_BuyWindow
{
    /// <summary>
    /// Логика взаимодействия для pgClientRegister.xaml
    /// </summary>
    public partial class pgClientRegister : Page
    {
        public pgClientRegister()
        {
            InitializeComponent();
            
        }

        private void Chek()
        {
            using (StreamWriter sw = new StreamWriter("Receipt.txt"))
            {

                // Записываем заголовок чека
                sw.WriteLine("Чек Аэропорта");
                sw.WriteLine("-------------------");

                // Записываем информацию о пассажире
                sw.WriteLine($"Имя Пассажира: {Name}") ;
                sw.WriteLine("ID Пассажира: 12345");
                sw.WriteLine("Номер Рейса: AA100");
                sw.WriteLine($"Отправление: {Classes.Information.cbxStart.Text}") ;
                sw.WriteLine($"Назначение: {Classes.Information.cbxEnd.Text}") ;

                // Записываем информацию о билете
                sw.WriteLine("Тип Билета: Эконом");
                sw.WriteLine("Цена: $500");

                // Записываем информацию о билете
                sw.WriteLine("-------------------");
                sw.WriteLine("Спасибо за выбор нашей авиакомпании!");
            }
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            classNavigation.MainFrame.Navigate(new Pages_BuyWindow.pgAdditionalConditions());

            Chek();
        }
    }
}
    
