﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Doan1
{
    public partial class MenuUC : UserControl
    {
        public MenuUC()
        {
            InitializeComponent();

            FileStream fs = new FileStream(@"C:\Users\Admin\Desktop\DOAN1\DoAn1\Doan1\Doan1\bin\Debug\dsnuoc.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            txbMenu.Text = sr.ReadToEnd();
            sr.Close();


        }
    }
}
