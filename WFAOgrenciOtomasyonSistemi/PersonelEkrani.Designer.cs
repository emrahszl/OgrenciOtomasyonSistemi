namespace WFAOgrenciOtomasyonSistemi
{
    partial class PersonelEkrani
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
            pbOgretmenGirisi = new PictureBox();
            pbMemurGirisi = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbOgretmenGirisi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMemurGirisi).BeginInit();
            SuspendLayout();
            // 
            // pbOgretmenGirisi
            // 
            pbOgretmenGirisi.Cursor = Cursors.Hand;
            pbOgretmenGirisi.Image = Properties.Resources.ogretmen;
            pbOgretmenGirisi.Location = new Point(150, 250);
            pbOgretmenGirisi.Name = "pbOgretmenGirisi";
            pbOgretmenGirisi.Size = new Size(150, 150);
            pbOgretmenGirisi.SizeMode = PictureBoxSizeMode.Zoom;
            pbOgretmenGirisi.TabIndex = 0;
            pbOgretmenGirisi.TabStop = false;
            pbOgretmenGirisi.Click += pbOgretmenGirisi_Click;
            // 
            // pbMemurGirisi
            // 
            pbMemurGirisi.Cursor = Cursors.Hand;
            pbMemurGirisi.Image = Properties.Resources.memur;
            pbMemurGirisi.Location = new Point(500, 250);
            pbMemurGirisi.Name = "pbMemurGirisi";
            pbMemurGirisi.Size = new Size(150, 150);
            pbMemurGirisi.SizeMode = PictureBoxSizeMode.Zoom;
            pbMemurGirisi.TabIndex = 0;
            pbMemurGirisi.TabStop = false;
            pbMemurGirisi.Click += pbMemurGirisi_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(267, 149);
            label3.Name = "label3";
            label3.Size = new Size(256, 37);
            label3.TabIndex = 5;
            label3.Text = "Personel Giriş Ekranı";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(150, 403);
            label1.Name = "label1";
            label1.Size = new Size(150, 27);
            label1.TabIndex = 6;
            label1.Text = "Öğretmen Girişi";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(500, 403);
            label2.Name = "label2";
            label2.Size = new Size(150, 27);
            label2.TabIndex = 6;
            label2.Text = "Memur Girişi";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PersonelEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(784, 561);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(pbMemurGirisi);
            Controls.Add(pbOgretmenGirisi);
            Name = "PersonelEkrani";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Öğrenci İşleri Personel Ekranı";
            ((System.ComponentModel.ISupportInitialize)pbOgretmenGirisi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMemurGirisi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbOgretmenGirisi;
        private PictureBox pbMemurGirisi;
        private Label label3;
        private Label label1;
        private Label label2;
    }
}