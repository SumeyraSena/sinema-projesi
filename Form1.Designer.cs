
namespace sistemafinal
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSalonEkle = new System.Windows.Forms.Button();
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.btnSeansEkle = new System.Windows.Forms.Button();
            this.btnSeansListele = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SatisListeleme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalonEkle
            // 
            this.btnSalonEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnSalonEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalonEkle.BackgroundImage")));
            this.btnSalonEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalonEkle.Location = new System.Drawing.Point(27, 12);
            this.btnSalonEkle.Name = "btnSalonEkle";
            this.btnSalonEkle.Size = new System.Drawing.Size(92, 103);
            this.btnSalonEkle.TabIndex = 0;
            this.btnSalonEkle.Text = "Salon Ekle";
            this.btnSalonEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalonEkle.UseVisualStyleBackColor = false;
            this.btnSalonEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFilmEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFilmEkle.BackgroundImage")));
            this.btnFilmEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFilmEkle.Location = new System.Drawing.Point(125, 12);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(92, 103);
            this.btnFilmEkle.TabIndex = 1;
            this.btnFilmEkle.Text = "Film Ekle";
            this.btnFilmEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFilmEkle.UseVisualStyleBackColor = false;
            this.btnFilmEkle.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSeansEkle
            // 
            this.btnSeansEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeansEkle.BackgroundImage")));
            this.btnSeansEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeansEkle.Location = new System.Drawing.Point(223, 12);
            this.btnSeansEkle.Name = "btnSeansEkle";
            this.btnSeansEkle.Size = new System.Drawing.Size(93, 103);
            this.btnSeansEkle.TabIndex = 2;
            this.btnSeansEkle.Text = "Seans Ekle";
            this.btnSeansEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeansEkle.UseVisualStyleBackColor = true;
            this.btnSeansEkle.Click += new System.EventHandler(this.btnSeansEkle_Click);
            // 
            // btnSeansListele
            // 
            this.btnSeansListele.BackColor = System.Drawing.Color.White;
            this.btnSeansListele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeansListele.BackgroundImage")));
            this.btnSeansListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeansListele.Location = new System.Drawing.Point(322, 12);
            this.btnSeansListele.Name = "btnSeansListele";
            this.btnSeansListele.Size = new System.Drawing.Size(93, 103);
            this.btnSeansListele.TabIndex = 3;
            this.btnSeansListele.Text = "SeansListe";
            this.btnSeansListele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeansListele.UseVisualStyleBackColor = false;
            this.btnSeansListele.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(521, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 103);
            this.button5.TabIndex = 4;
            this.button5.Text = "Çıkış";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(27, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 354);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SatisListeleme
            // 
            this.SatisListeleme.Location = new System.Drawing.Point(421, 12);
            this.SatisListeleme.Name = "SatisListeleme";
            this.SatisListeleme.Size = new System.Drawing.Size(95, 103);
            this.SatisListeleme.TabIndex = 6;
            this.SatisListeleme.Text = "Satış Listeleme";
            this.SatisListeleme.UseVisualStyleBackColor = true;
            this.SatisListeleme.Click += new System.EventHandler(this.SatisListeleme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(984, 564);
            this.Controls.Add(this.SatisListeleme);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnSeansListele);
            this.Controls.Add(this.btnSeansEkle);
            this.Controls.Add(this.btnFilmEkle);
            this.Controls.Add(this.btnSalonEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalonEkle;
        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.Button btnSeansEkle;
        private System.Windows.Forms.Button btnSeansListele;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SatisListeleme;
    }
}

