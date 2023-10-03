using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stajProje
{
    public partial class musteriListele : Form
    {
        public musteriListele()
        {
            InitializeComponent();
        }
        string baglantiCumlesi = "Data Source=ACER\\SQLEXPRESS;Initial Catalog=projeStaj;Integrated Security=True;TrustServerCertificate=True";

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void musteriListele_Load_1(object sender, EventArgs e)
        {
            Musteri_Listele();
        }
        public void Musteri_Listele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();


            SqlCommand komut = new SqlCommand("SELECT mTcno, mAdSoyad, mTel, mAdres FROM musteri;", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        public void Musteri_Guncelle()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Update musteri set mAdSoyad=@adsoyad,mTel=@telefon,mAdres=@adres where mTcno=@tc";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.Parameters.AddWithValue("@tc", textBoxTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", textBoxAdi.Text);
            komut.Parameters.AddWithValue("@telefon", mBoxTel.Text);
            komut.Parameters.AddWithValue("@adres", textBoxAdres.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Musteri_Listele();

        }
        public void Musteri_Sil()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Delete from musteriler where mTcno='" + dataGridView1.CurrentRow.Cells["mTcno"].Value.ToString() + "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);

            komut.ExecuteNonQuery();
            baglanti.Close();
            Musteri_Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            textBoxTc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            mBoxTel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxAdres.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("UPDATE musteri SET mAdSoyad=@adisoyadi,mTel=@telefon,mAdres=@adres WHERE mTcno = @tcno", baglanti);
            komut2.Parameters.AddWithValue("@tcno", textBoxTc.Text);
            komut2.Parameters.AddWithValue("@adisoyadi", textBoxAdi.Text);
            komut2.Parameters.AddWithValue("@telefon", mBoxTel.Text);
            komut2.Parameters.AddWithValue("@adres", textBoxAdres.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme Başarılı");
            Musteri_Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM musteri WHERE mTcno='" + dataGridView1.CurrentRow.Cells["mTcno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Musteri_Listele();
        }


    }

}
