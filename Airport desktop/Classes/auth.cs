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

namespace Airport_desktop.Classes
{
    class auth
    {
        private const string FileName = "authentication.txt";


        public static void Authe(TextBox tbLogin, PasswordBox pbPassword, Window currentWindow)
        {
            if (!File.Exists(FileName))
            {
                MessageBox.Show("Файл не существует.");

                using (StreamWriter Write = new StreamWriter(FileName, false, Encoding.Default))
                {
                    Write.Write("admin;admin;1");
                }

                MessageBox.Show("Файл создан.");
            }
            else
            {
                if (tbLogin.Text != "" && pbPassword.Password != "")
                {
                    CheckAccessRight(tbLogin, pbPassword, currentWindow);
                }
                else
                {
                    MessageBox.Show("Необходимо заполнить все поля авторизации.");
                }
            }
        }

        private static void CheckAccessRight(TextBox tbLogin, PasswordBox pbPassword, Window currentWindow)
        {
            Authority NewAuthority = new Authority(FileName, tbLogin.Text, pbPassword.Password);

            var X = NewAuthority.IncorrectInput();

            if (X.Count() != 0)
            {
                foreach (var Row in X)
                {
                    if (Row.Role == 1)
                    {
                        MessageBox.Show($"Вход под менеджером ({Row.User}).");
                        BuyWindow buyWindow = new BuyWindow();
                        buyWindow.Show();
                        currentWindow.Close();

                    }
                    else
                    {
                        MessageBox.Show($"Вход под админом ({Row.User}).");
                        BuyWindow buyWindow = new BuyWindow();
                        buyWindow.Show();
                        currentWindow.Close();

                        

                    }
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль. Повторите вход.");
            }
        }
    }

    public class Authority
    {
        private readonly string _FileName;

        private readonly string _Login;

        private readonly string _Password;

        public Authority(string FileName, string Login, string Password)
        {
            this._FileName = FileName;

            this._Login = Login;

            this._Password = Password;
        }

        public List<Authentication> IncorrectInput()
        {
            string[] Data = File.ReadAllLines(_FileName);

            List<Authentication> Lst = new List<Authentication>();

            for (int i = 0; i < Data.Length; i++)
            {
                Authentication Auth = new Authentication();

                string[] Row = Data[i].Split(';');

                Auth.User = Row[0];

                Auth.Password = Row[1];

                Auth.Role = Convert.ToInt32(Row[2]);

                Lst.Add(Auth);
            }

            return Lst.Where(w => w.User == _Login && w.Password == _Password).ToList();
        }
    }

    public struct Authentication
    {
        public string User { get; set; }

        public string Password { get; set; }

        public int Role { get; set; }
    }

    

}


