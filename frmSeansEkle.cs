using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemafinal
{
    public partial class frmSeansEkle : Form
    {
        public frmSeansEkle()
        {
            InitializeComponent();
        }
        sinemaTableAdapters.Seans_BilgileriTableAdapter filmseans = new sinemaTableAdapters.Seans_BilgileriTableAdapter();
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Sinema_Bileti;Integrated Security=True");


        

        private void FilmveSalonGoster(ComboBox combo, string sql, string sql2)
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sql, baglanti);

            SqlDataReader read = komut.ExecuteReader();
            while(read.Read()==true)
            {
                combo.Items.Add(read[sql2].ToString());
            }
            baglanti.Close();
        }

        private void frmSeansEkle_Load_1(object sender, EventArgs e)
        {

           FilmveSalonGoster(combofilm, "select * from film_bilgileri", "filmadi");
           FilmveSalonGoster(combosalon, "select * from salon_bilgileri", "salonadi");

        }

        string seans = "";
        private void RadioButtonSecilen()
        {
            if (radioButton1.Checked == true) seans = radioButton1.Text;
            else if (radioButton2.Checked == true) seans = radioButton2.Text;
            else if (radioButton3.Checked == true) seans = radioButton3.Text;
            else if (radioButton4.Checked == true) seans = radioButton4.Text;
            else if (radioButton5.Checked == true) seans = radioButton5.Text;
            else if (radioButton6.Checked == true) seans = radioButton6.Text;
            else if (radioButton7.Checked == true) seans = radioButton7.Text;
            else if (radioButton8.Checked == true) seans = radioButton8.Text;
            else if (radioButton9.Checked == true) seans = radioButton9.Text;
            else if (radioButton10.Checked == true) seans = radioButton10.Text;
            else if (radioButton11.Checked == true) seans = radioButton11.Text;
            else if (radioButton12.Checked == true) seans = radioButton12.Text;

        }
        private void btnseansekle_Click(object sender, EventArgs e)
        {
            if (seans != " ")
            {
                RadioButtonSecilen();
                filmseans.SeansEkleme(film.Text, salon.Text, starih.Text, seans);
                MessageBox.Show("Seans Ekleme İşlemi Yapıldı!", "Kayıt");

            }
            else if (seans == "") 
            {
                MessageBox.Show("Seans Seçimi Yapmadınız!", "Uyarı");
            }
        }

    }
}
