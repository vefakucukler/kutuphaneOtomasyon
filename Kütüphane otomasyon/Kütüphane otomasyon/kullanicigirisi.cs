using System;
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
    public partial class kullanicigirisi : Form
    {
        public kullanicigirisi()
        {
            InitializeComponent();
        }

        private void kullanicigirisi_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin"&&textBox2.Text=="1234")
            {
                Form ana = new anamenü();
                ana.Show();
                this.Hide();
            }

            else if (textBox1.Text==""&&textBox2.Text=="")
            {
                MessageBox.Show("Lütfen Bütün Alanları Doldurun!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                label1.Show();
                textBox2.Clear();
            }
        }

        private void kullanicigirisi_Load(object sender, EventArgs e)
        {
            label1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
