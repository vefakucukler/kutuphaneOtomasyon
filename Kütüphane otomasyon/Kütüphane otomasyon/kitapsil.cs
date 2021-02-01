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
    public partial class kitapsil : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=kutuphane_otomasyon; uid=root; Password=;");
        public kitapsil()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void kitapsil_Load(object sender, EventArgs e)
        {
            label5.Hide();
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            label5.Show();
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            label5.Hide();
        }

        private void txttc_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select * from kitap where barkodno LIKE '" + txttc.Text.ToString() + "'", baglanti);
            MySqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                txtadi.Text = okuyucu["kitapadi"].ToString();
                txtsoyadi.Text = okuyucu["yazari"].ToString();

            }
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("delete from kitap where barkodno=('" + txttc.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Kaydı Silindi.", "SİLME İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
            txttc.Clear();
            txtadi.Clear();
            txtsoyadi.Clear();
        }
    }
}
