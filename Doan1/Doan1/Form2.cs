﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Doan1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\Admin\OneDrive\Máy tính\DoAn1\Doan1\Doan1\bin\Debug\dsnuoc.txt", FileMode.Open);
            FileStream fs1 = new FileStream(@"C:\Users\Admin\OneDrive\Máy tính\DoAn1\Doan1\Doan1\bin\Debug\stt.txt", FileMode.Open);
            FileStream fs2 = new FileStream(@"C:\Users\Admin\OneDrive\Máy tính\DoAn1\Doan1\Doan1\bin\Debug\sttd.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            StreamReader sr1 = new StreamReader(fs1, Encoding.UTF8);
            StreamReader sr2 = new StreamReader(fs2, Encoding.UTF8);
            textBox2.Text = sr.ReadToEnd();
            textBox3.Text = sr1.ReadToEnd();
            textBox4.Text = sr2.ReadToEnd();
            sr.Close();
            sr1.Close();
            sr2.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\Admin\OneDrive\Máy tính\DoAn1\Doan1\Doan1\bin\Debug\gia.txt", FileMode.Open);
            FileStream fs1 = new FileStream(@"C:\Users\Admin\OneDrive\Máy tính\DoAn1\Doan1\Doan1\bin\Debug\stt.txt", FileMode.Open);
            
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            StreamReader sr1 = new StreamReader(fs1, Encoding.UTF8);
            
            textBox2.Text = sr.ReadToEnd();
            textBox3.Text = sr1.ReadToEnd();
            
            sr.Close();
            sr1.Close();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\Admin\OneDrive\Máy tính\DoAn1\Doan1\Doan1\bin\Debug\khuyenmai.txt", FileMode.Open);
            FileStream fs1 = new FileStream(@"C:\Users\Admin\OneDrive\Máy tính\DoAn1\Doan1\Doan1\bin\Debug\sttkm.txt", FileMode.Open);
            FileStream fs2 = new FileStream(@"C:\Users\Admin\OneDrive\Máy tính\DoAn1\Doan1\Doan1\bin\Debug\sttkms.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            StreamReader sr1 = new StreamReader(fs1, Encoding.UTF8);
            StreamReader sr2 = new StreamReader(fs2, Encoding.UTF8);
            textBox2.Text = sr.ReadToEnd();
            textBox3.Text = sr1.ReadToEnd();
            textBox4.Text = sr2.ReadToEnd();
            sr.Close();
            sr1.Close();
            sr2.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
