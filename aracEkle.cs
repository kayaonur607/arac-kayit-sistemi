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
    public partial class aracEkle : Form
    {
        public aracEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ACER\\SQLEXPRESS;Initial Catalog=projeStaj;Integrated Security=True;TrustServerCertificate=True");
        private void aracEkle_Load(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("SELECT * FROM musteri", baglanti);
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["mAdSoyad"]);
            }
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=ACER\\SQLEXPRESS;Initial Catalog=projeStaj;Integrated Security=True;TrustServerCertificate=True");

            baglanti.Open();
            string komutCumlesi = "INSERT INTO muayene VALUES (@aracsahibi,@aracplaka,@aracmarka,@aracmodel,@mucret,@mdurum,@mtarih)";
            SqlCommand command = new SqlCommand(komutCumlesi, baglanti);
            command.Parameters.AddWithValue("@aracsahibi", comboBox2.Text);
            command.Parameters.AddWithValue("@aracplaka", textBoxPlaka.Text);
            command.Parameters.AddWithValue("@aracmarka", textBoxMarka.Text);
            command.Parameters.AddWithValue("@aracmodel", textBoxModel.Text);
            command.Parameters.AddWithValue("@mucret", textBoxUcret.Text);
            command.Parameters.AddWithValue("@mdurum", comboBox1.Text);
            command.Parameters.AddWithValue("@mtarih", maskedTextBox1.Text);
            command.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı");
        }
    }
}
