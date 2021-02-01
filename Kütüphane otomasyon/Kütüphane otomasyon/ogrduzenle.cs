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
    public partial class ogrduzenle : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=kutuphane_otomasyon; uid=root; Password=;");
        public ogrduzenle()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtadi.Text != "" && txtadres.Text != "" && txtsoyadi.Text != "" && txttc.Text != "" && txttelefon.Text != "")
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("update ogrenciekle set tc='" + txttc.Text + "',adi='" + txtadi.Text + "',soyadi='" + txtsoyadi.Text + "',telefon='" + txttelefon.Text + "',adres='" + txtadres.Text + "' where tc='" + txttc.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Öğrenci Bilgileri Güncellendi.", "GÜNCELLEME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
                txttc.Clear();
                txtadi.Clear();
                txtsoyadi.Clear();
                txttelefon.Clear();
                txtadres.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen Bütün Alanları Doldurun!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txttc_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select * from ogrenciekle where tc LIKE '"+txttc.Text.ToString()+"'",baglanti);
            MySqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                txtadi.Text = okuyucu["adi"].ToString();
                txtsoyadi.Text = okuyucu["soyadi"].ToString();
                txttelefon.Text = okuyucu["telefon"].ToString();
                txtadres.Text = okuyucu["adres"].ToString();
            }
            baglanti.Close();

        }

        private void ogrduzenle_Load(object sender, EventArgs e)
        {

        }
    }
}
