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
    public partial class kitapduzenle : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=kutuphane_otomasyon; uid=root; Password=;");
        public kitapduzenle()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void kitapduzenle_Load(object sender, EventArgs e)
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

        private void txtbarkod_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select * from kitap where barkodno LIKE '" + txtbarkod.Text.ToString() + "'", baglanti);
            MySqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                txtadi.Text = okuyucu["kitapadi"].ToString();
                txtyazari.Text = okuyucu["yazari"].ToString();
                txtsayfasi.Text = okuyucu["sayfasayisi"].ToString();
                txtrafno.Text = okuyucu["rafno"].ToString();


            }
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtadi.Text != "" && txtyazari.Text != "" && txtsayfasi.Text != "" && txtbarkod.Text != "" && txtrafno.Text != "")
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("update kitap set barkodno='" + txtbarkod.Text + "',kitapadi='" + txtadi.Text + "',yazari='" + txtyazari.Text + "',sayfasayisi='" + txtsayfasi.Text + "',rafno='" + txtrafno.Text + "' where barkodno='" + txtbarkod.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kitap Bilgileri Güncellendi.", "GÜNCELLEME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
                txtyazari.Clear();
                txtadi.Clear();
                txtsayfasi.Clear();
                txtrafno.Clear();
                txtbarkod.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen Bütün Alanları Doldurun!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
