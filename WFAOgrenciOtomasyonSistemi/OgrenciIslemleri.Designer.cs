namespace WFAOgrenciOtomasyonSistemi
{
    partial class OgrenciIslemleri
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
            gbOgrenciEkle = new GroupBox();
            btnOgrenciEkle = new Button();
            txtOgrenciSoyad = new TextBox();
            label2 = new Label();
            txtOgrenciAd = new TextBox();
            label1 = new Label();
            gbOgrenciGuncelle = new GroupBox();
            dtpKayitTarihi = new DateTimePicker();
            txtGuncellenecekAd = new TextBox();
            txtGuncellenecekOgrenciNo = new TextBox();
            label7 = new Label();
            txtGuncellenecekSoyad = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            dgvOgrenciler = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            btnOgrenciSil = new Button();
            btnGuncelle = new Button();
            btnIptal = new Button();
            gbOgrenciEkle.SuspendLayout();
            gbOgrenciGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).BeginInit();
            SuspendLayout();
            // 
            // gbOgrenciEkle
            // 
            gbOgrenciEkle.BackColor = Color.BurlyWood;
            gbOgrenciEkle.Controls.Add(btnOgrenciEkle);
            gbOgrenciEkle.Controls.Add(txtOgrenciSoyad);
            gbOgrenciEkle.Controls.Add(label2);
            gbOgrenciEkle.Controls.Add(txtOgrenciAd);
            gbOgrenciEkle.Controls.Add(label1);
            gbOgrenciEkle.Location = new Point(13, 13);
            gbOgrenciEkle.Margin = new Padding(4);
            gbOgrenciEkle.Name = "gbOgrenciEkle";
            gbOgrenciEkle.Padding = new Padding(4);
            gbOgrenciEkle.Size = new Size(288, 218);
            gbOgrenciEkle.TabIndex = 0;
            gbOgrenciEkle.TabStop = false;
            gbOgrenciEkle.Text = "Öğrenci Ekle";
            // 
            // btnOgrenciEkle
            // 
            btnOgrenciEkle.Location = new Point(7, 163);
            btnOgrenciEkle.Margin = new Padding(4);
            btnOgrenciEkle.Name = "btnOgrenciEkle";
            btnOgrenciEkle.Size = new Size(272, 45);
            btnOgrenciEkle.TabIndex = 2;
            btnOgrenciEkle.Text = "Öğrenci Ekle";
            btnOgrenciEkle.UseVisualStyleBackColor = true;
            btnOgrenciEkle.Click += btnOgrenciEkle_Click;
            // 
            // txtOgrenciSoyad
            // 
            txtOgrenciSoyad.BorderStyle = BorderStyle.FixedSingle;
            txtOgrenciSoyad.Location = new Point(8, 126);
            txtOgrenciSoyad.Margin = new Padding(4);
            txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            txtOgrenciSoyad.Size = new Size(272, 29);
            txtOgrenciSoyad.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 101);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 0;
            label2.Text = "Soyad";
            // 
            // txtOgrenciAd
            // 
            txtOgrenciAd.BorderStyle = BorderStyle.FixedSingle;
            txtOgrenciAd.Location = new Point(8, 55);
            txtOgrenciAd.Margin = new Padding(4);
            txtOgrenciAd.Name = "txtOgrenciAd";
            txtOgrenciAd.Size = new Size(272, 29);
            txtOgrenciAd.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(29, 21);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // gbOgrenciGuncelle
            // 
            gbOgrenciGuncelle.BackColor = Color.BurlyWood;
            gbOgrenciGuncelle.Controls.Add(dtpKayitTarihi);
            gbOgrenciGuncelle.Controls.Add(txtGuncellenecekAd);
            gbOgrenciGuncelle.Controls.Add(txtGuncellenecekOgrenciNo);
            gbOgrenciGuncelle.Controls.Add(label7);
            gbOgrenciGuncelle.Controls.Add(txtGuncellenecekSoyad);
            gbOgrenciGuncelle.Controls.Add(label6);
            gbOgrenciGuncelle.Controls.Add(label4);
            gbOgrenciGuncelle.Controls.Add(label5);
            gbOgrenciGuncelle.Location = new Point(13, 249);
            gbOgrenciGuncelle.Margin = new Padding(4);
            gbOgrenciGuncelle.Name = "gbOgrenciGuncelle";
            gbOgrenciGuncelle.Padding = new Padding(4);
            gbOgrenciGuncelle.Size = new Size(287, 299);
            gbOgrenciGuncelle.TabIndex = 1;
            gbOgrenciGuncelle.TabStop = false;
            gbOgrenciGuncelle.Text = "Öğrenci Güncelle";
            // 
            // dtpKayitTarihi
            // 
            dtpKayitTarihi.Format = DateTimePickerFormat.Short;
            dtpKayitTarihi.Location = new Point(8, 251);
            dtpKayitTarihi.Name = "dtpKayitTarihi";
            dtpKayitTarihi.Size = new Size(271, 29);
            dtpKayitTarihi.TabIndex = 2;
            // 
            // txtGuncellenecekAd
            // 
            txtGuncellenecekAd.BorderStyle = BorderStyle.FixedSingle;
            txtGuncellenecekAd.Location = new Point(8, 55);
            txtGuncellenecekAd.Margin = new Padding(4);
            txtGuncellenecekAd.Name = "txtGuncellenecekAd";
            txtGuncellenecekAd.Size = new Size(271, 29);
            txtGuncellenecekAd.TabIndex = 1;
            // 
            // txtGuncellenecekOgrenciNo
            // 
            txtGuncellenecekOgrenciNo.BorderStyle = BorderStyle.FixedSingle;
            txtGuncellenecekOgrenciNo.Location = new Point(8, 183);
            txtGuncellenecekOgrenciNo.Margin = new Padding(4);
            txtGuncellenecekOgrenciNo.Name = "txtGuncellenecekOgrenciNo";
            txtGuncellenecekOgrenciNo.Size = new Size(271, 29);
            txtGuncellenecekOgrenciNo.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 227);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(85, 21);
            label7.TabIndex = 0;
            label7.Text = "Kayıt Tarihi";
            // 
            // txtGuncellenecekSoyad
            // 
            txtGuncellenecekSoyad.BorderStyle = BorderStyle.FixedSingle;
            txtGuncellenecekSoyad.Location = new Point(8, 117);
            txtGuncellenecekSoyad.Margin = new Padding(4);
            txtGuncellenecekSoyad.Name = "txtGuncellenecekSoyad";
            txtGuncellenecekSoyad.Size = new Size(271, 29);
            txtGuncellenecekSoyad.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 158);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(90, 21);
            label6.TabIndex = 0;
            label6.Text = "Öğrenci No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 30);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(29, 21);
            label4.TabIndex = 0;
            label4.Text = "Ad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 92);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 0;
            label5.Text = "Soyad";
            // 
            // dgvOgrenciler
            // 
            dgvOgrenciler.AllowUserToAddRows = false;
            dgvOgrenciler.AllowUserToDeleteRows = false;
            dgvOgrenciler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOgrenciler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOgrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgrenciler.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvOgrenciler.Location = new Point(308, 56);
            dgvOgrenciler.MultiSelect = false;
            dgvOgrenciler.Name = "dgvOgrenciler";
            dgvOgrenciler.ReadOnly = true;
            dgvOgrenciler.RowHeadersVisible = false;
            dgvOgrenciler.RowTemplate.Height = 25;
            dgvOgrenciler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOgrenciler.Size = new Size(464, 456);
            dgvOgrenciler.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "OgrenciNo";
            Column1.HeaderText = "Öğrenci No";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "OgrenciAd";
            Column2.HeaderText = "Öğrenci Adı";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "OgrenciSoyad";
            Column3.HeaderText = "Öğrenci Soyadı";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "KayitTarihi";
            Column4.HeaderText = "Kayıt Tarihi";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(333, 13);
            label3.Name = "label3";
            label3.Size = new Size(439, 40);
            label3.TabIndex = 3;
            label3.Text = "Öğrenci Listesi";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOgrenciSil
            // 
            btnOgrenciSil.Location = new Point(662, 518);
            btnOgrenciSil.Name = "btnOgrenciSil";
            btnOgrenciSil.Size = new Size(110, 30);
            btnOgrenciSil.TabIndex = 4;
            btnOgrenciSil.Text = "Kaydı Sil";
            btnOgrenciSil.UseVisualStyleBackColor = true;
            btnOgrenciSil.Visible = false;
            btnOgrenciSil.Click += btnOgrenciSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(546, 519);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(110, 29);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Visible = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(460, 520);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(80, 29);
            btnIptal.TabIndex = 5;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Visible = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // OgrenciIslemleri
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(btnIptal);
            Controls.Add(btnGuncelle);
            Controls.Add(btnOgrenciSil);
            Controls.Add(label3);
            Controls.Add(dgvOgrenciler);
            Controls.Add(gbOgrenciGuncelle);
            Controls.Add(gbOgrenciEkle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "OgrenciIslemleri";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Öğrenci İşlemleri";
            gbOgrenciEkle.ResumeLayout(false);
            gbOgrenciEkle.PerformLayout();
            gbOgrenciGuncelle.ResumeLayout(false);
            gbOgrenciGuncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbOgrenciEkle;
        private GroupBox gbOgrenciGuncelle;
        private Button btnOgrenciEkle;
        private TextBox txtOgrenciSoyad;
        private Label label2;
        private TextBox txtOgrenciAd;
        private Label label1;
        private DataGridView dgvOgrenciler;
        private Label label3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button btnOgrenciSil;
        private TextBox txtGuncellenecekAd;
        private TextBox txtGuncellenecekSoyad;
        private Label label4;
        private Label label5;
        private Button btnGuncelle;
        private Button btnIptal;
        private TextBox txtGuncellenecekOgrenciNo;
        private Label label7;
        private Label label6;
        private DateTimePicker dtpKayitTarihi;
    }
}