namespace WFAOgrenciOtomasyonSistemi
{
    partial class OgretmenEkrani
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
            pbNotGir = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbNotGir).BeginInit();
            SuspendLayout();
            // 
            // pbNotGir
            // 
            pbNotGir.Cursor = Cursors.Hand;
            pbNotGir.Image = Properties.Resources.notepad;
            pbNotGir.Location = new Point(325, 175);
            pbNotGir.Name = "pbNotGir";
            pbNotGir.Size = new Size(150, 150);
            pbNotGir.SizeMode = PictureBoxSizeMode.Zoom;
            pbNotGir.TabIndex = 0;
            pbNotGir.TabStop = false;
            pbNotGir.Click += pbNotGir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(290, 328);
            label1.Name = "label1";
            label1.Size = new Size(221, 21);
            label1.TabIndex = 1;
            label1.Text = "Öğrenci Ders Notu İşlemleri";
            // 
            // OgretmenEkrani
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(784, 561);
            Controls.Add(label1);
            Controls.Add(pbNotGir);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "OgretmenEkrani";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Öğretmen Ekranı";
            ((System.ComponentModel.ISupportInitialize)pbNotGir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbNotGir;
        private Label label1;
    }
}