namespace WFAOgrenciOtomasyonSistemi
{
    partial class DersEkleCikarIslemleri
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
            cbOgrenciDonemSec = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            lblOgrenciAdSoyad = new Label();
            btnDersKayit = new Button();
            pnlDersler = new Panel();
            SuspendLayout();
            // 
            // cbOgrenciDonemSec
            // 
            cbOgrenciDonemSec.FormattingEnabled = true;
            cbOgrenciDonemSec.Location = new Point(288, 86);
            cbOgrenciDonemSec.Name = "cbOgrenciDonemSec";
            cbOgrenciDonemSec.Size = new Size(206, 29);
            cbOgrenciDonemSec.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(347, 62);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 2;
            label1.Text = "Dönem Seç";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(319, 169);
            label2.Name = "label2";
            label2.Size = new Size(152, 21);
            label2.TabIndex = 2;
            label2.Text = "Seçilebilecek Dersler";
            // 
            // lblOgrenciAdSoyad
            // 
            lblOgrenciAdSoyad.AutoSize = true;
            lblOgrenciAdSoyad.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblOgrenciAdSoyad.ForeColor = Color.White;
            lblOgrenciAdSoyad.Location = new Point(12, 34);
            lblOgrenciAdSoyad.Name = "lblOgrenciAdSoyad";
            lblOgrenciAdSoyad.Size = new Size(0, 30);
            lblOgrenciAdSoyad.TabIndex = 4;
            // 
            // btnDersKayit
            // 
            btnDersKayit.Location = new Point(641, 510);
            btnDersKayit.Name = "btnDersKayit";
            btnDersKayit.Size = new Size(131, 39);
            btnDersKayit.TabIndex = 5;
            btnDersKayit.Text = "Dersleri Kaydet";
            btnDersKayit.UseVisualStyleBackColor = true;
            btnDersKayit.Click += btnDersKayit_Click;
            // 
            // pnlDersler
            // 
            pnlDersler.Location = new Point(12, 206);
            pnlDersler.Name = "pnlDersler";
            pnlDersler.Size = new Size(760, 298);
            pnlDersler.TabIndex = 6;
            // 
            // DersEkleCikarIslemleri
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(784, 561);
            Controls.Add(pnlDersler);
            Controls.Add(btnDersKayit);
            Controls.Add(lblOgrenciAdSoyad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbOgrenciDonemSec);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "DersEkleCikarIslemleri";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ders Ekle-Çıkar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbOgrenciDonemSec;
        private Label label1;
        private Label label2;
        private Label lblOgrenciAdSoyad;
        private Button btnDersKayit;
        private Panel pnlDersler;
    }
}