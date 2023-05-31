namespace WFAOgrenciOtomasyonSistemi
{
    partial class MemurEkrani
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
            pbDonemIslemleri = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            pbDersIslemleri = new PictureBox();
            pbOgrenciIslemleri = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbDonemIslemleri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDersIslemleri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOgrenciIslemleri).BeginInit();
            SuspendLayout();
            // 
            // pbDonemIslemleri
            // 
            pbDonemIslemleri.Cursor = Cursors.Hand;
            pbDonemIslemleri.Image = Properties.Resources.semester;
            pbDonemIslemleri.Location = new Point(319, 240);
            pbDonemIslemleri.Name = "pbDonemIslemleri";
            pbDonemIslemleri.Size = new Size(150, 150);
            pbDonemIslemleri.SizeMode = PictureBoxSizeMode.Zoom;
            pbDonemIslemleri.TabIndex = 14;
            pbDonemIslemleri.TabStop = false;
            pbDonemIslemleri.Click += pbDonemIslemleri_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(492, 393);
            label2.Name = "label2";
            label2.Size = new Size(150, 27);
            label2.TabIndex = 11;
            label2.Text = "Ders İşlemleri";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(319, 393);
            label4.Name = "label4";
            label4.Size = new Size(150, 27);
            label4.TabIndex = 12;
            label4.Text = "Dönem İşlemleri";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(142, 393);
            label1.Name = "label1";
            label1.Size = new Size(150, 27);
            label1.TabIndex = 13;
            label1.Text = "Öğrenci İşlemleri";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(222, 140);
            label3.Name = "label3";
            label3.Size = new Size(358, 37);
            label3.TabIndex = 10;
            label3.Text = "Öğrenci İşleri Personel Ekranı";
            // 
            // pbDersIslemleri
            // 
            pbDersIslemleri.Cursor = Cursors.Hand;
            pbDersIslemleri.Image = Properties.Resources.courses;
            pbDersIslemleri.Location = new Point(492, 240);
            pbDersIslemleri.Name = "pbDersIslemleri";
            pbDersIslemleri.Size = new Size(150, 150);
            pbDersIslemleri.SizeMode = PictureBoxSizeMode.Zoom;
            pbDersIslemleri.TabIndex = 8;
            pbDersIslemleri.TabStop = false;
            pbDersIslemleri.Click += pbDersIslemleri_Click;
            // 
            // pbOgrenciIslemleri
            // 
            pbOgrenciIslemleri.Cursor = Cursors.Hand;
            pbOgrenciIslemleri.Image = Properties.Resources.student;
            pbOgrenciIslemleri.Location = new Point(142, 240);
            pbOgrenciIslemleri.Name = "pbOgrenciIslemleri";
            pbOgrenciIslemleri.Size = new Size(150, 150);
            pbOgrenciIslemleri.SizeMode = PictureBoxSizeMode.Zoom;
            pbOgrenciIslemleri.TabIndex = 9;
            pbOgrenciIslemleri.TabStop = false;
            pbOgrenciIslemleri.Click += pbOgrenciIslemleri_Click;
            // 
            // MemurEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(784, 561);
            Controls.Add(pbDonemIslemleri);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(pbDersIslemleri);
            Controls.Add(pbOgrenciIslemleri);
            Name = "MemurEkrani";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Öğrenci İşleri Personel Ekranı";
            ((System.ComponentModel.ISupportInitialize)pbDonemIslemleri).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDersIslemleri).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOgrenciIslemleri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbDonemIslemleri;
        private Label label2;
        private Label label4;
        private Label label1;
        private Label label3;
        private PictureBox pbDersIslemleri;
        private PictureBox pbOgrenciIslemleri;
    }
}