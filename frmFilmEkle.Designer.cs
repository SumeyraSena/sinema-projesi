
namespace sistemafinal
{
    partial class frmFilmEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilmEkle));
            this.filmadiekle = new System.Windows.Forms.TextBox();
            this.yonetmenadi = new System.Windows.Forms.TextBox();
            this.filmturu = new System.Windows.Forms.ComboBox();
            this.filmsuresi = new System.Windows.Forms.TextBox();
            this.yapimyili = new System.Windows.Forms.TextBox();
            this.btnfilmekle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnafissec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // filmadiekle
            // 
            this.filmadiekle.Location = new System.Drawing.Point(570, 24);
            this.filmadiekle.Name = "filmadiekle";
            this.filmadiekle.Size = new System.Drawing.Size(157, 22);
            this.filmadiekle.TabIndex = 0;
            // 
            // yonetmenadi
            // 
            this.yonetmenadi.Location = new System.Drawing.Point(571, 52);
            this.yonetmenadi.Name = "yonetmenadi";
            this.yonetmenadi.Size = new System.Drawing.Size(157, 22);
            this.yonetmenadi.TabIndex = 1;
            // 
            // filmturu
            // 
            this.filmturu.FormattingEnabled = true;
            this.filmturu.Location = new System.Drawing.Point(571, 80);
            this.filmturu.Name = "filmturu";
            this.filmturu.Size = new System.Drawing.Size(154, 24);
            this.filmturu.TabIndex = 2;
            // 
            // filmsuresi
            // 
            this.filmsuresi.Location = new System.Drawing.Point(570, 110);
            this.filmsuresi.Name = "filmsuresi";
            this.filmsuresi.Size = new System.Drawing.Size(157, 22);
            this.filmsuresi.TabIndex = 3;
            // 
            // yapimyili
            // 
            this.yapimyili.Location = new System.Drawing.Point(568, 138);
            this.yapimyili.Name = "yapimyili";
            this.yapimyili.Size = new System.Drawing.Size(159, 22);
            this.yapimyili.TabIndex = 4;
            // 
            // btnfilmekle
            // 
            this.btnfilmekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfilmekle.ImageIndex = 0;
            this.btnfilmekle.ImageList = this.ımageList1;
            this.btnfilmekle.Location = new System.Drawing.Point(624, 269);
            this.btnfilmekle.Name = "btnfilmekle";
            this.btnfilmekle.Size = new System.Drawing.Size(98, 42);
            this.btnfilmekle.TabIndex = 5;
            this.btnfilmekle.Text = "Film Ekle";
            this.btnfilmekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnfilmekle.UseVisualStyleBackColor = true;
            this.btnfilmekle.Click += new System.EventHandler(this.btnfilmsec_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "cinema-vector-logo-film-vest-emblem-cinema-vector-logo-film-vest-emblem-design-11" +
        "2657424.jpg");
            // 
            // btnafissec
            // 
            this.btnafissec.Location = new System.Drawing.Point(413, 269);
            this.btnafissec.Name = "btnafissec";
            this.btnafissec.Size = new System.Drawing.Size(109, 40);
            this.btnafissec.TabIndex = 6;
            this.btnafissec.Text = "Afiş Seç";
            this.btnafissec.UseVisualStyleBackColor = true;
            this.btnafissec.Click += new System.EventHandler(this.btnafissec_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(368, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 200);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(565, 166);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(162, 22);
            this.tarih.TabIndex = 8;
            // 
            // frmFilmEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(751, 358);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnafissec);
            this.Controls.Add(this.btnfilmekle);
            this.Controls.Add(this.yapimyili);
            this.Controls.Add(this.filmsuresi);
            this.Controls.Add(this.filmturu);
            this.Controls.Add(this.yonetmenadi);
            this.Controls.Add(this.filmadiekle);
            this.Name = "frmFilmEkle";
            this.Text = "Film Ekleme Sayfası";
            this.Load += new System.EventHandler(this.frmFilmEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filmadiekle;
        private System.Windows.Forms.TextBox yonetmenadi;
        private System.Windows.Forms.ComboBox filmturu;
        private System.Windows.Forms.TextBox filmsuresi;
        private System.Windows.Forms.TextBox yapimyili;
        private System.Windows.Forms.Button btnfilmekle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnafissec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker tarih;
    }
}