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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace stajProje
{
    public partial class aracListele : Form
    {
        public aracListele()
        {
            InitializeComponent();
        }
        string baglantiCumlesi = "Data Source=ACER\\SQLEXPRESS;Initial Catalog=projeStaj;Integrated Security=True;TrustServerCertificate=True";
        public void Arac_Listele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();


            SqlCommand komut = new SqlCommand("SELECT * FROM muayene;", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();


        }
        public void Arac_Listele_1()
        {

        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("UPDATE muayene SET aracMarka=@marka,aracModel=@model,mUcret=@ucret,mDurum =@durum,mTarih=@tarih WHERE aracSahibi = @sahip", baglanti);
            komut2.Parameters.AddWithValue("@sahip", comboBox2.Text);
            komut2.Parameters.AddWithValue("@marka", textBoxMarka.Text);
            komut2.Parameters.AddWithValue("@ucret", textBoxUcret.Text);
            komut2.Parameters.AddWithValue("@model", textBoxModel.Text);
            komut2.Parameters.AddWithValue("@durum", comboBox1.Text);
            komut2.Parameters.AddWithValue("@tarih", maskedTextBox1.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme Başarılı");
            Arac_Listele();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM muayene WHERE aracPlaka='" + dataGridView1.CurrentRow.Cells["aracPlaka"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Arac_Listele();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aracListele_Load_1(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            SqlCommand komut = new SqlCommand("SELECT aracSahibi FROM muayene", baglanti);
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["aracSahibi"]);
            }


            baglanti.Close();
            Arac_Listele();
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            comboBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxPlaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxMarka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxModel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxUcret.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }





        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
