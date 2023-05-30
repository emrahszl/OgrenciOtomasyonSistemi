namespace WFAOgrenciOtomasyonSistemi
{
    partial class DonemIslemleri
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
            label1 = new Label();
            cbOgrenciListesi = new ComboBox();
            dgvOgrenciListesi = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btnDonemEkle = new Button();
            label2 = new Label();
            cbDonemListesi = new ComboBox();
            btnDonemSil = new Button();
            btnDonemGuncelle = new Button();
            dgvSecilenOgrencininDonemleri = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciListesi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSecilenOgrencininDonemleri).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(317, 53);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci Seçiniz";
            // 
            // cbOgrenciListesi
            // 
            cbOgrenciListesi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOgrenciListesi.FormattingEnabled = true;
            cbOgrenciListesi.Items.AddRange(new object[] { "Öğrenci seçiniz..." });
            cbOgrenciListesi.Location = new Point(248, 77);
            cbOgrenciListesi.Name = "cbOgrenciListesi";
            cbOgrenciListesi.Size = new Size(257, 23);
            cbOgrenciListesi.TabIndex = 1;
            // 
            // dgvOgrenciListesi
            // 
            dgvOgrenciListesi.AllowUserToAddRows = false;
            dgvOgrenciListesi.AllowUserToDeleteRows = false;
            dgvOgrenciListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOgrenciListesi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOgrenciListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgrenciListesi.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvOgrenciListesi.Location = new Point(12, 264);
            dgvOgrenciListesi.MultiSelect = false;
            dgvOgrenciListesi.Name = "dgvOgrenciListesi";
            dgvOgrenciListesi.ReadOnly = true;
            dgvOgrenciListesi.RowHeadersVisible = false;
            dgvOgrenciListesi.RowTemplate.Height = 25;
            dgvOgrenciListesi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOgrenciListesi.Size = new Size(375, 250);
            dgvOgrenciListesi.TabIndex = 2;
            dgvOgrenciListesi.CellClick += dgvOgrenciListesi_CellClick;
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
            Column2.HeaderText = "Öğrenci Ad";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "OgrenciSoyad";
            Column3.HeaderText = "Öğrenci Soyad";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // btnDonemEkle
            // 
            btnDonemEkle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDonemEkle.Location = new Point(248, 185);
            btnDonemEkle.Name = "btnDonemEkle";
            btnDonemEkle.Size = new Size(257, 33);
            btnDonemEkle.TabIndex = 3;
            btnDonemEkle.Text = "Dönem Ekle";
            btnDonemEkle.UseVisualStyleBackColor = true;
            btnDonemEkle.Click += btnDonemEkle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(317, 116);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 4;
            label2.Text = "Dönem Seçiniz";
            // 
            // cbDonemListesi
            // 
            cbDonemListesi.FormattingEnabled = true;
            cbDonemListesi.Items.AddRange(new object[] { "Dönem seçiniz..." });
            cbDonemListesi.Location = new Point(248, 140);
            cbDonemListesi.Name = "cbDonemListesi";
            cbDonemListesi.Size = new Size(257, 23);
            cbDonemListesi.TabIndex = 5;
            // 
            // btnDonemSil
            // 
            btnDonemSil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDonemSil.Location = new Point(697, 520);
            btnDonemSil.Name = "btnDonemSil";
            btnDonemSil.Size = new Size(75, 29);
            btnDonemSil.TabIndex = 6;
            btnDonemSil.Text = "Sil";
            btnDonemSil.UseVisualStyleBackColor = true;
            btnDonemSil.Visible = false;
            btnDonemSil.Click += btnDonemSil_Click;
            // 
            // btnDonemGuncelle
            // 
            btnDonemGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDonemGuncelle.Location = new Point(602, 520);
            btnDonemGuncelle.Name = "btnDonemGuncelle";
            btnDonemGuncelle.Size = new Size(89, 29);
            btnDonemGuncelle.TabIndex = 6;
            btnDonemGuncelle.Text = "Güncelle";
            btnDonemGuncelle.UseVisualStyleBackColor = true;
            btnDonemGuncelle.Visible = false;
            btnDonemGuncelle.Click += btnDonemGuncelle_Click;
            // 
            // dgvSecilenOgrencininDonemleri
            // 
            dgvSecilenOgrencininDonemleri.AllowUserToAddRows = false;
            dgvSecilenOgrencininDonemleri.AllowUserToDeleteRows = false;
            dgvSecilenOgrencininDonemleri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSecilenOgrencininDonemleri.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSecilenOgrencininDonemleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSecilenOgrencininDonemleri.Columns.AddRange(new DataGridViewColumn[] { Column4, Column5, Column6, Column7 });
            dgvSecilenOgrencininDonemleri.Location = new Point(393, 264);
            dgvSecilenOgrencininDonemleri.MultiSelect = false;
            dgvSecilenOgrencininDonemleri.Name = "dgvSecilenOgrencininDonemleri";
            dgvSecilenOgrencininDonemleri.ReadOnly = true;
            dgvSecilenOgrencininDonemleri.RowHeadersVisible = false;
            dgvSecilenOgrencininDonemleri.RowTemplate.Height = 25;
            dgvSecilenOgrencininDonemleri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSecilenOgrencininDonemleri.Size = new Size(375, 250);
            dgvSecilenOgrencininDonemleri.TabIndex = 7;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "DonemAdi";
            Column4.HeaderText = "Dönem Adı";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "DonemKredisi";
            Column5.HeaderText = "Kredi";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "DonemNotOrtalamasi";
            Column6.HeaderText = "Not Ortalaması";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "DonemHarfNotu";
            Column7.HeaderText = "Harf Notu";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(134, 240);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 8;
            label3.Text = "Öğrenciler";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(544, 240);
            label4.Name = "label4";
            label4.Size = new Size(86, 21);
            label4.TabIndex = 8;
            label4.Text = "Dönemler";
            // 
            // DonemIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(784, 561);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgvSecilenOgrencininDonemleri);
            Controls.Add(btnDonemGuncelle);
            Controls.Add(btnDonemSil);
            Controls.Add(cbDonemListesi);
            Controls.Add(label2);
            Controls.Add(btnDonemEkle);
            Controls.Add(dgvOgrenciListesi);
            Controls.Add(cbOgrenciListesi);
            Controls.Add(label1);
            Name = "DonemIslemleri";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dönem İşlemleri";
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciListesi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSecilenOgrencininDonemleri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbOgrenciListesi;
        private DataGridView dgvOgrenciListesi;
        private Button btnDonemEkle;
        private Label label2;
        private ComboBox cbDonemListesi;
        private Button btnDonemSil;
        private Button btnDonemGuncelle;
        private DataGridView dgvSecilenOgrencininDonemleri;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}