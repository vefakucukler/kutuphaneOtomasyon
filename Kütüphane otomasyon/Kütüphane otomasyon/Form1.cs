﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value<100)
            {
                progressBar1.Value = progressBar1.Value + 1;
            }
            else
            {
                timer1.Enabled = false;
                Form kullanıcı = new kullanicigirisi();
                kullanıcı.Show();
                this.Hide();

            }
        }
    }
}
