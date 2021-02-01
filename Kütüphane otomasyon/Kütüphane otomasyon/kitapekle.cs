using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kütüphane_otomasyon
{
    public partial class kitapekle : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=kutuphane_otomasyon; uid=root; Password=;");
        public kitapekle()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void kitapekle_Load(object sender, EventArgs e)
        {
            label7.Hide();
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            label7.Show();
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            label7.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtbarkod.Text != "" && txtadi.Text != "" && txtsayfasi.Text != "" && txtyazari.Text != "" && txtrafno.Text != "")
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("insert into kitap (barkodno,kitapadi,yazari,sayfasayisi,rafno) values ('" + txtbarkod.Text + "','" + txtadi.Text + "','" + txtyazari.Text + "','" + txtsayfasi.Text + "','" + txtrafno.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kitap Kaydı Başarıyla Tamamlandı.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                baglanti.Close();
                txtadi.Clear();
                txtbarkod.Clear();
                txtrafno.Clear();
                txtsayfasi.Clear();
                txtyazari.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen Bütün Alanları Doldurun!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
