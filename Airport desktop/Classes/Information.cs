﻿using System;
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
    class Information
    {
        public static ComboBox cbxStart { get; set; }
        public static ComboBox cbxEnd { get; set; }
        public static  TextBox price { get; set; }


    }
}
