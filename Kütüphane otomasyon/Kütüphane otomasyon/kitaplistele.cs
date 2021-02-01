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
    public partial class kitaplistele : Form
    {

        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=kutuphane_otomasyon; uid=root; Password=;");
        DataTable tablo = new DataTable();
        public kitaplistele()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kitaplistele_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from kitap", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                baglanti.Open();
                tablo.Clear();
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from kitap", baglanti);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                tablo.Clear();
                MySqlDataAdapter adtr = new MySqlDataAdapter("Select * From kitap where barkodno like '%" + textBox1.Text + "%'", baglanti);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }
        }
    }
}
