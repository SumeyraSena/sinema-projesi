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

namespace sistemafinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Sinema_Bileti;Integrated Security=True");
        int sayac = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            sayac = 1;

            for (int i = 0; i < 8; i++)
            {
                
                for (int j = 0; j < 9; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.BackColor = Color.White;
                    btn.Location = new Point(j * 30 + 20, i * 30 + 20);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    
                    if (j == 4)
                    {
                        continue;
                    }

                    sayac++;
                    this.panel1.Controls.Add(btn);
                    
                }
                
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmSeansListele ekle = new frmSeansListele();
            ekle.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            frmSalonEkle ekle = new frmSalonEkle();
            ekle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmFilmEkle ekle = new frmFilmEkle();
            ekle.Show();
            this.Hide();
        }

        private void btnSeansEkle_Click(object sender, EventArgs e)
        {
            frmSeansEkle ekle = new frmSeansEkle();
            ekle.Show();
            this.Hide();
        }

        private void SatisListeleme_Click(object sender, EventArgs e)
        {
            frmSatisListeleme satis = new frmSatisListeleme();
            satis.ShowDialog();
        }
    }
}
