namespace WFAOgrenciOtomasyonSistemi
{
    partial class AnaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pbPersonelGiris = new PictureBox();
            pbOgrenciGiris = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPersonelGiris).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOgrenciGiris).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(150, 403);
            label1.Name = "label1";
            label1.Size = new Size(150, 27);
            label1.TabIndex = 1;
            label1.Text = "Personel Girişi";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbPersonelGiris
            // 
            pbPersonelGiris.Cursor = Cursors.Hand;
            pbPersonelGiris.Image = Properties.Resources.employeelogin;
            pbPersonelGiris.Location = new Point(150, 250);
            pbPersonelGiris.Name = "pbPersonelGiris";
            pbPersonelGiris.Size = new Size(150, 150);
            pbPersonelGiris.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonelGiris.TabIndex = 2;
            pbPersonelGiris.TabStop = false;
            pbPersonelGiris.Click += pbPersonelGiris_Click;
            // 
            // pbOgrenciGiris
            // 
            pbOgrenciGiris.Cursor = Cursors.Hand;
            pbOgrenciGiris.Image = Properties.Resources.studentlogin;
            pbOgrenciGiris.Location = new Point(500, 250);
            pbOgrenciGiris.Name = "pbOgrenciGiris";
            pbOgrenciGiris.Size = new Size(150, 150);
            pbOgrenciGiris.SizeMode = PictureBoxSizeMode.Zoom;
            pbOgrenciGiris.TabIndex = 3;
            pbOgrenciGiris.TabStop = false;
            pbOgrenciGiris.Click += pbOgrenciGiris_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(500, 403);
            label2.Name = "label2";
            label2.Size = new Size(150, 27);
            label2.TabIndex = 1;
            label2.Text = "Öğrenci Girişi";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(230, 150);
            label3.Name = "label3";
            label3.Size = new Size(333, 37);
            label3.TabIndex = 4;
            label3.Text = "Otomasyona Hoşgeldiniz...";
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(784, 561);
            Controls.Add(label3);
            Controls.Add(pbOgrenciGiris);
            Controls.Add(pbPersonelGiris);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "AnaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "X Üniversitesi Bilgi Yönetim Sistemi";
            FormClosing += AnaForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbPersonelGiris).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOgrenciGiris).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pbPersonelGiris;
        private PictureBox pbOgrenciGiris;
        private Label label2;
        private Label label3;
    }
}