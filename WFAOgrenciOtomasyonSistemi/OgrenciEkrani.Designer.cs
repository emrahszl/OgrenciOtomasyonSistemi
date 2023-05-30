namespace WFAOgrenciOtomasyonSistemi
{
    partial class OgrenciEkrani
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
            cbKullanicilar = new ComboBox();
            label1 = new Label();
            btnGirisYap = new Button();
            pnlSecenekler = new Panel();
            pbNotGoruntule = new PictureBox();
            label3 = new Label();
            pbDersEkleCikar = new PictureBox();
            label2 = new Label();
            pnlSecenekler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbNotGoruntule).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDersEkleCikar).BeginInit();
            SuspendLayout();
            // 
            // cbKullanicilar
            // 
            cbKullanicilar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKullanicilar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbKullanicilar.FormattingEnabled = true;
            cbKullanicilar.Location = new Point(242, 82);
            cbKullanicilar.Name = "cbKullanicilar";
            cbKullanicilar.Size = new Size(300, 29);
            cbKullanicilar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(332, 49);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Seç";
            // 
            // btnGirisYap
            // 
            btnGirisYap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGirisYap.Location = new Point(242, 154);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(300, 34);
            btnGirisYap.TabIndex = 2;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // pnlSecenekler
            // 
            pnlSecenekler.Controls.Add(pbNotGoruntule);
            pnlSecenekler.Controls.Add(label3);
            pnlSecenekler.Controls.Add(pbDersEkleCikar);
            pnlSecenekler.Controls.Add(label2);
            pnlSecenekler.Location = new Point(12, 260);
            pnlSecenekler.Name = "pnlSecenekler";
            pnlSecenekler.Size = new Size(760, 289);
            pnlSecenekler.TabIndex = 3;
            pnlSecenekler.Visible = false;
            // 
            // pbNotGoruntule
            // 
            pbNotGoruntule.Cursor = Cursors.Hand;
            pbNotGoruntule.Image = Properties.Resources.notgoruntule;
            pbNotGoruntule.Location = new Point(466, 45);
            pbNotGoruntule.Name = "pbNotGoruntule";
            pbNotGoruntule.Size = new Size(150, 150);
            pbNotGoruntule.SizeMode = PictureBoxSizeMode.Zoom;
            pbNotGoruntule.TabIndex = 0;
            pbNotGoruntule.TabStop = false;
            pbNotGoruntule.Click += pbNotGoruntule_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(469, 198);
            label3.Name = "label3";
            label3.Size = new Size(144, 21);
            label3.TabIndex = 1;
            label3.Text = "Not Görüntüleme";
            // 
            // pbDersEkleCikar
            // 
            pbDersEkleCikar.Cursor = Cursors.Hand;
            pbDersEkleCikar.Image = Properties.Resources.eklecikar;
            pbDersEkleCikar.Location = new Point(139, 45);
            pbDersEkleCikar.Name = "pbDersEkleCikar";
            pbDersEkleCikar.Size = new Size(150, 150);
            pbDersEkleCikar.SizeMode = PictureBoxSizeMode.Zoom;
            pbDersEkleCikar.TabIndex = 0;
            pbDersEkleCikar.TabStop = false;
            pbDersEkleCikar.Click += pbDersEkleCikar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(114, 198);
            label2.Name = "label2";
            label2.Size = new Size(195, 21);
            label2.TabIndex = 1;
            label2.Text = "Ders Ekle-Çıkar İşlemleri";
            // 
            // OgrenciEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(784, 561);
            Controls.Add(pnlSecenekler);
            Controls.Add(btnGirisYap);
            Controls.Add(label1);
            Controls.Add(cbKullanicilar);
            Name = "OgrenciEkrani";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Öğrenci Bilgi Sistemi";
            pnlSecenekler.ResumeLayout(false);
            pnlSecenekler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbNotGoruntule).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDersEkleCikar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbKullanicilar;
        private Label label1;
        private Button btnGirisYap;
        private Panel pnlSecenekler;
        private PictureBox pbDersEkleCikar;
        private PictureBox pbNotGoruntule;
        private Label label3;
        private Label label2;
    }
}