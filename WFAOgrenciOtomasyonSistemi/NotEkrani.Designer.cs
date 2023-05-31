namespace WFAOgrenciOtomasyonSistemi
{
    partial class NotEkrani
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
            cbOgrenciler = new ComboBox();
            label1 = new Label();
            cbDonemler = new ComboBox();
            label2 = new Label();
            cbDersler = new ComboBox();
            label3 = new Label();
            pnlNotGirisEkrani = new Panel();
            txtVizeNotu = new TextBox();
            txtDersNotu = new TextBox();
            txtFinalNotu = new TextBox();
            dgvOgrenciDersler = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            btnOgrenciyeDonemDersiEkle = new Button();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            pnlNotGirisEkrani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciDersler).BeginInit();
            SuspendLayout();
            // 
            // cbOgrenciler
            // 
            cbOgrenciler.FormattingEnabled = true;
            cbOgrenciler.Location = new Point(179, 51);
            cbOgrenciler.Margin = new Padding(4);
            cbOgrenciler.Name = "cbOgrenciler";
            cbOgrenciler.Size = new Size(419, 29);
            cbOgrenciler.TabIndex = 0;
            cbOgrenciler.SelectedIndexChanged += cbOgrenciler_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(330, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 1;
            label1.Text = "Öğrenci Seç";
            // 
            // cbDonemler
            // 
            cbDonemler.FormattingEnabled = true;
            cbDonemler.Location = new Point(179, 117);
            cbDonemler.Margin = new Padding(4);
            cbDonemler.Name = "cbDonemler";
            cbDonemler.Size = new Size(419, 29);
            cbDonemler.TabIndex = 0;
            cbDonemler.SelectedIndexChanged += cbDonemler_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(330, 92);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 1;
            label2.Text = "Dönem Seç";
            // 
            // cbDersler
            // 
            cbDersler.FormattingEnabled = true;
            cbDersler.Location = new Point(179, 185);
            cbDersler.Margin = new Padding(4);
            cbDersler.Name = "cbDersler";
            cbDersler.Size = new Size(419, 29);
            cbDersler.TabIndex = 0;
            cbDersler.SelectedIndexChanged += cbDersler_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(339, 160);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 1;
            label3.Text = "Ders Seç";
            // 
            // pnlNotGirisEkrani
            // 
            pnlNotGirisEkrani.Controls.Add(txtVizeNotu);
            pnlNotGirisEkrani.Controls.Add(txtDersNotu);
            pnlNotGirisEkrani.Controls.Add(txtFinalNotu);
            pnlNotGirisEkrani.Controls.Add(dgvOgrenciDersler);
            pnlNotGirisEkrani.Controls.Add(btnOgrenciyeDonemDersiEkle);
            pnlNotGirisEkrani.Controls.Add(label8);
            pnlNotGirisEkrani.Controls.Add(label9);
            pnlNotGirisEkrani.Controls.Add(label7);
            pnlNotGirisEkrani.Location = new Point(12, 225);
            pnlNotGirisEkrani.Name = "pnlNotGirisEkrani";
            pnlNotGirisEkrani.Size = new Size(760, 324);
            pnlNotGirisEkrani.TabIndex = 2;
            pnlNotGirisEkrani.Visible = false;
            // 
            // txtVizeNotu
            // 
            txtVizeNotu.Location = new Point(91, 33);
            txtVizeNotu.Name = "txtVizeNotu";
            txtVizeNotu.Size = new Size(100, 29);
            txtVizeNotu.TabIndex = 11;
            // 
            // txtDersNotu
            // 
            txtDersNotu.Enabled = false;
            txtDersNotu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDersNotu.Location = new Point(375, 33);
            txtDersNotu.Name = "txtDersNotu";
            txtDersNotu.Size = new Size(100, 29);
            txtDersNotu.TabIndex = 12;
            // 
            // txtFinalNotu
            // 
            txtFinalNotu.Location = new Point(234, 33);
            txtFinalNotu.Name = "txtFinalNotu";
            txtFinalNotu.Size = new Size(100, 29);
            txtFinalNotu.TabIndex = 13;
            // 
            // dgvOgrenciDersler
            // 
            dgvOgrenciDersler.AllowUserToAddRows = false;
            dgvOgrenciDersler.AllowUserToDeleteRows = false;
            dgvOgrenciDersler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOgrenciDersler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOgrenciDersler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgrenciDersler.Columns.AddRange(new DataGridViewColumn[] { Column4, Column5, Column6, Column7 });
            dgvOgrenciDersler.Location = new Point(3, 80);
            dgvOgrenciDersler.MultiSelect = false;
            dgvOgrenciDersler.Name = "dgvOgrenciDersler";
            dgvOgrenciDersler.ReadOnly = true;
            dgvOgrenciDersler.RowHeadersVisible = false;
            dgvOgrenciDersler.RowTemplate.Height = 25;
            dgvOgrenciDersler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOgrenciDersler.Size = new Size(754, 241);
            dgvOgrenciDersler.TabIndex = 10;
            dgvOgrenciDersler.Visible = false;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "DersKodu";
            Column4.HeaderText = "Ders Kodu";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "DersAdi";
            Column5.HeaderText = "Ders Adı";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Kredi";
            Column6.HeaderText = "Kredi";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "HarfNotu";
            Column7.HeaderText = "Harf Notu";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // btnOgrenciyeDonemDersiEkle
            // 
            btnOgrenciyeDonemDersiEkle.Location = new Point(514, 33);
            btnOgrenciyeDonemDersiEkle.Name = "btnOgrenciyeDonemDersiEkle";
            btnOgrenciyeDonemDersiEkle.Size = new Size(141, 29);
            btnOgrenciyeDonemDersiEkle.TabIndex = 9;
            btnOgrenciyeDonemDersiEkle.Text = "Not Ekle";
            btnOgrenciyeDonemDersiEkle.UseVisualStyleBackColor = true;
            btnOgrenciyeDonemDersiEkle.Click += btnOgrenciyeDonemDersiEkle_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(101, 9);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(78, 21);
            label8.TabIndex = 6;
            label8.Text = "Vize Notu";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(385, 9);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(81, 21);
            label9.TabIndex = 7;
            label9.Text = "Ders Notu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(244, 9);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(82, 21);
            label7.TabIndex = 8;
            label7.Text = "Final Notu";
            // 
            // NotEkrani
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(784, 561);
            Controls.Add(pnlNotGirisEkrani);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbDersler);
            Controls.Add(cbDonemler);
            Controls.Add(cbOgrenciler);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "NotEkrani";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Not Girme/Düzenleme Ekranı";
            pnlNotGirisEkrani.ResumeLayout(false);
            pnlNotGirisEkrani.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciDersler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbOgrenciler;
        private Label label1;
        private ComboBox cbDonemler;
        private Label label2;
        private ComboBox cbDersler;
        private Label label3;
        private Panel pnlNotGirisEkrani;
        private TextBox txtVizeNotu;
        private TextBox txtDersNotu;
        private TextBox txtFinalNotu;
        private DataGridView dgvOgrenciDersler;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button btnOgrenciyeDonemDersiEkle;
        private Label label8;
        private Label label9;
        private Label label7;
    }
}