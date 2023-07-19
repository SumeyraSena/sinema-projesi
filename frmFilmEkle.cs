using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemafinal
{
    public partial class frmFilmEkle : Form
    {
        public frmFilmEkle()
        {
            InitializeComponent();
        }
        sinemaTableAdapters.Film_BilgileriTableAdapter film = new sinemaTableAdapters.Film_BilgileriTableAdapter();

        private void frmFilmEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnfilmsec_Click(object sender, EventArgs e)
        {
            try
            {
                film.FilmEkleme(filmadiekle.Text, yonetmenadi.Text, filmturu.Text, filmsuresi.Text, tarih.Text, yapimyili.Text, pictureBox1.ImageLocation);
                MessageBox.Show("Film bilgileri eklendi!", "Kayıt");
            }
            catch (Exception)
            {

                MessageBox.Show("Bu film daha önce eklendi!", "Uyarı");
            }
            
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            filmturu.Text = "";

        }

        private void btnafissec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }
    }
}
