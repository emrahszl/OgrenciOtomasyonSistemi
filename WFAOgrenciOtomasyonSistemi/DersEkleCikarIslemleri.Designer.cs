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
            lviDersler = new ListView();
            lblOgrenciAdSoyad = new Label();
            btnOnayla = new Button();
            SuspendLayout();
            // 
            // cbOgrenciDonemSec
            // 
            cbOgrenciDonemSec.FormattingEnabled = true;
            cbOgrenciDonemSec.Location = new Point(285, 139);
            cbOgrenciDonemSec.Name = "cbOgrenciDonemSec";
            cbOgrenciDonemSec.Size = new Size(206, 29);
            cbOgrenciDonemSec.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(344, 115);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 2;
            label1.Text = "Dönem Seç";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(347, 202);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 2;
            label2.Text = "Ders Seç";
            // 
            // lviDersler
            // 
            lviDersler.BackColor = Color.CadetBlue;
            lviDersler.BorderStyle = BorderStyle.None;
            lviDersler.Location = new Point(12, 243);
            lviDersler.Name = "lviDersler";
            lviDersler.Size = new Size(760, 261);
            lviDersler.TabIndex = 3;
            lviDersler.UseCompatibleStateImageBehavior = false;
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
            // btnOnayla
            // 
            btnOnayla.Location = new Point(673, 510);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(99, 39);
            btnOnayla.TabIndex = 5;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = true;
            // 
            // DersEkleCikarIslemleri
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(784, 561);
            Controls.Add(btnOnayla);
            Controls.Add(lblOgrenciAdSoyad);
            Controls.Add(lviDersler);
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
        private ListView lviDersler;
        private Label lblOgrenciAdSoyad;
        private Button btnOnayla;
    }
}