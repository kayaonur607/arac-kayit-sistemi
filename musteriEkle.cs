using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace stajProje
{
    public partial class musteriEkle : Form
    {
        public musteriEkle()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=ACER\\SQLEXPRESS;Initial Catalog=projeStaj;Integrated Security=True;TrustServerCertificate=True");

            baglanti.Open();
            string komutCumlesi = "INSERT INTO musteri VALUES (@tcno,@adsoyad,@tel,@adres)";
            SqlCommand command = new SqlCommand(komutCumlesi, baglanti);
            command.Parameters.AddWithValue("@tcno", textBoxTc.Text);
            command.Parameters.AddWithValue("@adsoyad", textBoxAdi.Text);
            command.Parameters.AddWithValue("@tel", mBoxTel.Text);
            command.Parameters.AddWithValue("@adres", textBoxAdres.Text);
            command.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı");
        }
    }
}
