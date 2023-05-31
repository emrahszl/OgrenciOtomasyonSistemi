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
            label1 = new Label();
            gbUniversiteyeDersEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDersler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKredi).BeginInit();
            SuspendLayout();
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
            gbUniversiteyeDersEkle.Location = new Point(12, 63);
            gbUniversiteyeDersEkle.Name = "gbUniversiteyeDersEkle";
            gbUniversiteyeDersEkle.Size = new Size(760, 486);
            gbUniversiteyeDersEkle.TabIndex = 5;
            gbUniversiteyeDersEkle.TabStop = false;
            gbUniversiteyeDersEkle.Text = "Ders Ekle";
            // 
            // dgvDersler
            // 
            dgvDersler.AllowUserToAddRows = false;
            dgvDersler.AllowUserToDeleteRows = false;
            dgvDersler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDersler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDersler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDersler.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvDersler.Location = new Point(306, 34);
            dgvDersler.MultiSelect = false;
            dgvDersler.Name = "dgvDersler";
            dgvDersler.ReadOnly = true;
            dgvDersler.RowHeadersVisible = false;
            dgvDersler.RowTemplate.Height = 25;
            dgvDersler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDersler.Size = new Size(448, 406);
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
            btnDersGuncelle.Location = new Point(594, 446);
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
            btnDersSil.Location = new Point(685, 446);
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
            btnDersEkle.Location = new Point(6, 249);
            btnDersEkle.Name = "btnDersEkle";
            btnDersEkle.Size = new Size(243, 34);
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
            txtDersKodu.Size = new Size(243, 29);
            txtDersKodu.TabIndex = 0;
            // 
            // txtDersAdi
            // 
            txtDersAdi.BorderStyle = BorderStyle.FixedSingle;
            txtDersAdi.Location = new Point(6, 58);
            txtDersAdi.Name = "txtDersAdi";
            txtDersAdi.Size = new Size(243, 29);
            txtDersAdi.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(235, 30);
            label1.Name = "label1";
            label1.Size = new Size(321, 30);
            label1.TabIndex = 6;
            label1.Text = "Üniversite Ders Ekleme Ekranı";
            // 
            // DersIslemleri
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(784, 561);
            Controls.Add(label1);
            Controls.Add(gbUniversiteyeDersEkle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "DersIslemleri";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ders İşlemleri";
            gbUniversiteyeDersEkle.ResumeLayout(false);
            gbUniversiteyeDersEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDersler).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKredi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Label label1;
    }
}