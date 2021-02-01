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
    public partial class ogrsil : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=kutuphane_otomasyon; uid=root; Password=;");
        public ogrsil()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("delete from ogrenciekle where tc=('"+txttc.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Kaydı Silindi.","SİLME İŞLEMİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            baglanti.Close();
            txttc.Clear();
            txtadi.Clear();
            txtsoyadi.Clear();
        }

        private void txttc_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select * from ogrenciekle where tc LIKE '" + txttc.Text.ToString() + "'", baglanti);
            MySqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                txtadi.Text = okuyucu["adi"].ToString();
                txtsoyadi.Text = okuyucu["soyadi"].ToString();
                
            }
            baglanti.Close();
        }
    }
}
