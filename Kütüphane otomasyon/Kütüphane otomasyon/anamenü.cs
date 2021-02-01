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
    public partial class anamenü : Form
    {
        public anamenü()
        {
            InitializeComponent();
        }
       

       

        private void anamenü_Load(object sender, EventArgs e)
        {
            label9.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
        }

       

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            label1.Hide();
        }

       

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            label2.Hide();
        }

       

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            label3.Hide();
        }

       
        private void button7_MouseLeave(object sender, EventArgs e)
        {
            label4.Hide();
        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            label4.Show();
        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Show();
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Show();
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Show();
        }

        private void button11_MouseMove(object sender, MouseEventArgs e)
        {
            label8.Show();
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            label8.Hide();
        }

        private void button10_MouseMove(object sender, MouseEventArgs e)
        {
            label7.Show();
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            label7.Hide();
        }

        private void button9_MouseMove(object sender, MouseEventArgs e)
        {
            label6.Show();
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            label6.Hide();
        }

        private void button8_MouseMove(object sender, MouseEventArgs e)
        {
            label5.Show();
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            label5.Hide();
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
                    button8.Visible = true;
                    button9.Visible = true;
                    button10.Visible = true;
                    button11.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;

            Form ogrekle = new ogrenciekle();
            ogrekle.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;

            Form ogrekle = new ogrenciekle();
            ogrekle.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;

            Form ogrsil = new ogrsil();
            ogrsil.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;

            Form ogrduznele = new ogrduzenle();
            ogrduznele.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;

            Form ogrlistele = new ogrlistele();
            ogrlistele.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;

            Form kitapekle = new kitapekle();
            kitapekle.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;

            Form kitapsil = new kitapsil();
            kitapsil.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;

            Form kitapduzenle = new kitapduzenle();
            kitapduzenle.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;

            Form kitaplistele = new kitaplistele();
            kitaplistele.Show();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button12.Visible = true;
        }

        private void button12_MouseMove(object sender, MouseEventArgs e)
        {
            label9.Show();
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            label9.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;

            Form geckitap = new geckitap();
            geckitap.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
