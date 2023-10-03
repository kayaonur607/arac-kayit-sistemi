using System.Windows.Forms;

namespace stajProje
{
    public partial class anaSayfa : Form
    {
        public anaSayfa()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            musteriListele musteriListele = new musteriListele();
            musteriListele.Show();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            musteriEkle musteriEkle = new musteriEkle();
            musteriEkle.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            aracListele aracListele = new aracListele();
            aracListele.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            aracEkle aracEkle = new aracEkle();
            aracEkle.Show();
        }
    }
}