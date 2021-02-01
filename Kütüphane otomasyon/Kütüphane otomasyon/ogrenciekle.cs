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
    public partial class ogrenciekle : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=kutuphane_otomasyon; uid=root; Password=;");
        
        public ogrenciekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (txtadi.Text != "" && txtadres.Text != "" && txtsoyadi.Text != "" && txttc.Text != "" && txttelefon.Text != "")
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("insert into ogrenciekle (tc,adi,soyadi,telefon,adres) values ('" + txttc.Text + "','" + txtadi.Text + "','" + txtsoyadi.Text + "','" + txttelefon.Text + "','" + txtadres.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Öğrenci Kaydı Başarılı.", "TAMAMLANDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnresim_Click(object sender, EventArgs e)
        {

        }

        private void ogrenciekle_Load(object sender, EventArgs e)
        {

        }
    }
}
