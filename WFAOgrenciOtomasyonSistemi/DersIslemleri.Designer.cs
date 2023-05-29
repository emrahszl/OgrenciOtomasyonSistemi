namespace WFAOgrenciOtomasyonSistemi
{
    partial class DersIslemleri
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
            cbOgrenciler = new ComboBox();
            label2 = new Label();
            cbDonemler = new ComboBox();
            gbOgrenciyeDersEkle = new GroupBox();
            btnUniversiteyeDersEkle = new Button();
            btnOgrenciyeDersEkle = new Button();
            gbUniversiteyeDersEkle = new GroupBox();
            dgvDersler = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btnDersGuncelle = new Button();
            btnDersSil = new Button();
            btnDersEkle = new Button();
            label5 = new Label();
            nudKredi = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            txtDersKodu = new TextBox();
            txtDersAdi = new TextBox();
            label6 = new Label();
            cbDersler = new ComboBox();
            btnOgrenciyeDonemDersiEkle = new Button();
            dgvOgrenciDersler = new DataGridView();
            btnOgrenciDersiniSil = new Button();
            btnOgrenciDersiniGuncelle = new Button();
            gbOgrenciyeDersEkle.SuspendLayout();
            gbUniversiteyeDersEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDersler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKredi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciDersler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci Seç";
            // 
            // cbOgrenciler
            // 
            cbOgrenciler.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOgrenciler.FormattingEnabled = true;
            cbOgrenciler.Location = new Point(6, 58);
            cbOgrenciler.Name = "cbOgrenciler";
            cbOgrenciler.Size = new Size(358, 29);
            cbOgrenciler.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 98);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 0;
            label2.Text = "Dönem Seç";
            // 
            // cbDonemler
            // 
            cbDonemler.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDonemler.FormattingEnabled = true;
            cbDonemler.Location = new Point(6, 122);
            cbDonemler.Name = "cbDonemler";
            cbDonemler.Size = new Size(358, 29);
            cbDonemler.TabIndex = 1;
            // 
            // gbOgrenciyeDersEkle
            // 
            gbOgrenciyeDersEkle.Controls.Add(dgvOgrenciDersler);
            gbOgrenciyeDersEkle.Controls.Add(btnOgrenciDersiniGuncelle);
            gbOgrenciyeDersEkle.Controls.Add(btnOgrenciDersiniSil);
            gbOgrenciyeDersEkle.Controls.Add(btnOgrenciyeDonemDersiEkle);
            gbOgrenciyeDersEkle.Controls.Add(cbDersler);
            gbOgrenciyeDersEkle.Controls.Add(cbDonemler);
            gbOgrenciyeDersEkle.Controls.Add(label1);
            gbOgrenciyeDersEkle.Controls.Add(label6);
            gbOgrenciyeDersEkle.Controls.Add(cbOgrenciler);
            gbOgrenciyeDersEkle.Controls.Add(label2);
            gbOgrenciyeDersEkle.Location = new Point(408, 84);
            gbOgrenciyeDersEkle.Name = "gbOgrenciyeDersEkle";
            gbOgrenciyeDersEkle.Size = new Size(370, 465);
            gbOgrenciyeDersEkle.TabIndex = 3;
            gbOgrenciyeDersEkle.TabStop = false;
            gbOgrenciyeDersEkle.Text = "Ders Ekle";
            gbOgrenciyeDersEkle.Visible = false;
            // 
            // btnUniversiteyeDersEkle
            // 
            btnUniversiteyeDersEkle.Location = new Point(102, 33);
            btnUniversiteyeDersEkle.Name = "btnUniversiteyeDersEkle";
            btnUniversiteyeDersEkle.Size = new Size(178, 45);
            btnUniversiteyeDersEkle.TabIndex = 4;
            btnUniversiteyeDersEkle.Text = "Üniversiteye Ders Ekle";
            btnUniversiteyeDersEkle.UseVisualStyleBackColor = true;
            btnUniversiteyeDersEkle.Click += btnUniversiteyeDersEkle_Click;
            // 
            // btnOgrenciyeDersEkle
            // 
            btnOgrenciyeDersEkle.Location = new Point(502, 33);
            btnOgrenciyeDersEkle.Name = "btnOgrenciyeDersEkle";
            btnOgrenciyeDersEkle.Size = new Size(178, 45);
            btnOgrenciyeDersEkle.TabIndex = 4;
            btnOgrenciyeDersEkle.Text = "Öğrenciye Ders Ekle";
            btnOgrenciyeDersEkle.UseVisualStyleBackColor = true;
            btnOgrenciyeDersEkle.Click += btnOgrenciyeDersEkle_Click;
            // 
            // gbUniversiteyeDersEkle
            // 
            gbUniversiteyeDersEkle.Controls.Add(dgvDersler);
            gbUniversiteyeDersEkle.Controls.Add(btnDersGuncelle);
            gbUniversiteyeDersEkle.Controls.Add(btnDersSil);
            gbUniversiteyeDersEkle.Controls.Add(btnDersEkle);
            gbUniversiteyeDersEkle.Controls.Add(label5);
            gbUniversiteyeDersEkle.Controls.Add(nudKredi);
            gbUniversiteyeDersEkle.Controls.Add(label4);
            gbUniversiteyeDersEkle.Controls.Add(label3);
            gbUniversiteyeDersEkle.Controls.Add(txtDersKodu);
            gbUniversiteyeDersEkle.Controls.Add(txtDersAdi);
            gbUniversiteyeDersEkle.Location = new Point(12, 84);
            gbUniversiteyeDersEkle.Name = "gbUniversiteyeDersEkle";
            gbUniversiteyeDersEkle.Size = new Size(370, 465);
            gbUniversiteyeDersEkle.TabIndex = 5;
            gbUniversiteyeDersEkle.TabStop = false;
            gbUniversiteyeDersEkle.Text = "Ders Ekle";
            gbUniversiteyeDersEkle.Visible = false;
            // 
            // dgvDersler
            // 
            dgvDersler.AllowUserToAddRows = false;
            dgvDersler.AllowUserToDeleteRows = false;
            dgvDersler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDersler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDersler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDersler.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvDersler.Location = new Point(7, 263);
            dgvDersler.MultiSelect = false;
            dgvDersler.Name = "dgvDersler";
            dgvDersler.ReadOnly = true;
            dgvDersler.RowHeadersVisible = false;
            dgvDersler.RowTemplate.Height = 25;
            dgvDersler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDersler.Size = new Size(358, 159);
            dgvDersler.TabIndex = 5;
            dgvDersler.Visible = false;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "DersKodu";
            Column1.HeaderText = "Ders Kodu";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "DersAdi";
            Column2.HeaderText = "Ders Adı";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Kredi";
            Column3.HeaderText = "Kredi";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // btnDersGuncelle
            // 
            btnDersGuncelle.Location = new Point(203, 425);
            btnDersGuncelle.Name = "btnDersGuncelle";
            btnDersGuncelle.Size = new Size(85, 34);
            btnDersGuncelle.TabIndex = 4;
            btnDersGuncelle.Text = "Güncelle";
            btnDersGuncelle.UseVisualStyleBackColor = true;
            btnDersGuncelle.Visible = false;
            btnDersGuncelle.Click += btnDersGuncelle_Click;
            // 
            // btnDersSil
            // 
            btnDersSil.Location = new Point(294, 425);
            btnDersSil.Name = "btnDersSil";
            btnDersSil.Size = new Size(70, 34);
            btnDersSil.TabIndex = 4;
            btnDersSil.Text = "Sil";
            btnDersSil.UseVisualStyleBackColor = true;
            btnDersSil.Visible = false;
            btnDersSil.Click += btnDersSil_Click;
            // 
            // btnDersEkle
            // 
            btnDersEkle.Location = new Point(6, 223);
            btnDersEkle.Name = "btnDersEkle";
            btnDersEkle.Size = new Size(358, 34);
            btnDersEkle.TabIndex = 4;
            btnDersEkle.Text = "Dersi Ekle";
            btnDersEkle.UseVisualStyleBackColor = true;
            btnDersEkle.Click += btnDersEkle_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 162);
            label5.Name = "label5";
            label5.Size = new Size(46, 21);
            label5.TabIndex = 3;
            label5.Text = "Kredi";
            // 
            // nudKredi
            // 
            nudKredi.Location = new Point(7, 187);
            nudKredi.Margin = new Padding(4);
            nudKredi.Name = "nudKredi";
            nudKredi.Size = new Size(132, 29);
            nudKredi.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 98);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 1;
            label4.Text = "Ders Kodu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 34);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 1;
            label3.Text = "Ders Adı";
            // 
            // txtDersKodu
            // 
            txtDersKodu.BorderStyle = BorderStyle.FixedSingle;
            txtDersKodu.Location = new Point(6, 122);
            txtDersKodu.Name = "txtDersKodu";
            txtDersKodu.Size = new Size(358, 29);
            txtDersKodu.TabIndex = 0;
            // 
            // txtDersAdi
            // 
            txtDersAdi.BorderStyle = BorderStyle.FixedSingle;
            txtDersAdi.Location = new Point(6, 58);
            txtDersAdi.Name = "txtDersAdi";
            txtDersAdi.Size = new Size(358, 29);
            txtDersAdi.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 162);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 21);
            label6.TabIndex = 0;
            label6.Text = "Ders Seç";
            // 
            // cbDersler
            // 
            cbDersler.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDersler.FormattingEnabled = true;
            cbDersler.Location = new Point(6, 186);
            cbDersler.Name = "cbDersler";
            cbDersler.Size = new Size(358, 29);
            cbDersler.TabIndex = 1;
            // 
            // btnOgrenciyeDonemDersiEkle
            // 
            btnOgrenciyeDonemDersiEkle.Location = new Point(6, 223);
            btnOgrenciyeDonemDersiEkle.Name = "btnOgrenciyeDonemDersiEkle";
            btnOgrenciyeDonemDersiEkle.Size = new Size(358, 34);
            btnOgrenciyeDonemDersiEkle.TabIndex = 2;
            btnOgrenciyeDonemDersiEkle.Text = "Dersi Ekle";
            btnOgrenciyeDonemDersiEkle.UseVisualStyleBackColor = true;
            // 
            // dgvOgrenciDersler
            // 
            dgvOgrenciDersler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOgrenciDersler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOgrenciDersler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgrenciDersler.ColumnHeadersVisible = false;
            dgvOgrenciDersler.Location = new Point(6, 263);
            dgvOgrenciDersler.MultiSelect = false;
            dgvOgrenciDersler.Name = "dgvOgrenciDersler";
            dgvOgrenciDersler.RowTemplate.Height = 25;
            dgvOgrenciDersler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOgrenciDersler.Size = new Size(358, 159);
            dgvOgrenciDersler.TabIndex = 3;
            dgvOgrenciDersler.Visible = false;
            // 
            // btnOgrenciDersiniSil
            // 
            btnOgrenciDersiniSil.Location = new Point(294, 425);
            btnOgrenciDersiniSil.Name = "btnOgrenciDersiniSil";
            btnOgrenciDersiniSil.Size = new Size(70, 34);
            btnOgrenciDersiniSil.TabIndex = 4;
            btnOgrenciDersiniSil.Text = "Sil";
            btnOgrenciDersiniSil.UseVisualStyleBackColor = true;
            btnOgrenciDersiniSil.Visible = false;
            // 
            // btnOgrenciDersiniGuncelle
            // 
            btnOgrenciDersiniGuncelle.Location = new Point(203, 425);
            btnOgrenciDersiniGuncelle.Name = "btnOgrenciDersiniGuncelle";
            btnOgrenciDersiniGuncelle.Size = new Size(85, 34);
            btnOgrenciDersiniGuncelle.TabIndex = 4;
            btnOgrenciDersiniGuncelle.Text = "Güncelle";
            btnOgrenciDersiniGuncelle.UseVisualStyleBackColor = true;
            btnOgrenciDersiniGuncelle.Visible = false;
            // 
            // DersIslemleri
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(gbUniversiteyeDersEkle);
            Controls.Add(btnOgrenciyeDersEkle);
            Controls.Add(btnUniversiteyeDersEkle);
            Controls.Add(gbOgrenciyeDersEkle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "DersIslemleri";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ders İşlemleri";
            gbOgrenciyeDersEkle.ResumeLayout(false);
            gbOgrenciyeDersEkle.PerformLayout();
            gbUniversiteyeDersEkle.ResumeLayout(false);
            gbUniversiteyeDersEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDersler).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKredi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciDersler).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private ComboBox cbOgrenciler;
        private Label label2;
        private ComboBox cbDonemler;
        private GroupBox gbOgrenciyeDersEkle;
        private Button btnUniversiteyeDersEkle;
        private Button btnOgrenciyeDersEkle;
        private GroupBox gbUniversiteyeDersEkle;
        private Button btnDersSil;
        private Button btnDersEkle;
        private Label label5;
        private NumericUpDown nudKredi;
        private Label label4;
        private Label label3;
        private TextBox txtDersKodu;
        private TextBox txtDersAdi;
        private DataGridView dgvDersler;
        private Button btnDersGuncelle;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridView dgvOgrenciDersler;
        private Button btnOgrenciDersiniGuncelle;
        private Button btnOgrenciDersiniSil;
        private Button btnOgrenciyeDonemDersiEkle;
        private ComboBox cbDersler;
        private Label label6;
    }
}