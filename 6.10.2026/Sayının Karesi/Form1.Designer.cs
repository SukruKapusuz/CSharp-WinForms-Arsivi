namespace Sayının_Karesi
{
    partial class Form1
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
            hesapla = new Button();
            txtSayi = new TextBox();
            label1 = new Label();
            lblkaresi = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // hesapla
            // 
            hesapla.Location = new Point(125, 148);
            hesapla.Name = "hesapla";
            hesapla.Size = new Size(75, 23);
            hesapla.TabIndex = 0;
            hesapla.Text = "Karesini al";
            hesapla.UseVisualStyleBackColor = true;
            hesapla.Click += button1_Click;
            // 
            // txtSayi
            // 
            txtSayi.Location = new Point(197, 24);
            txtSayi.Name = "txtSayi";
            txtSayi.Size = new Size(100, 23);
            txtSayi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(27, 26);
            label1.Name = "label1";
            label1.Size = new Size(164, 21);
            label1.TabIndex = 2;
            label1.Text = "Karesi Alınacak sayı:";
            // 
            // lblkaresi
            // 
            lblkaresi.AutoSize = true;
            lblkaresi.Location = new Point(108, 82);
            lblkaresi.Name = "lblkaresi";
            lblkaresi.Size = new Size(0, 15);
            lblkaresi.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(27, 76);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 4;
            label3.Text = "Karesi:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(343, 260);
            Controls.Add(label3);
            Controls.Add(lblkaresi);
            Controls.Add(label1);
            Controls.Add(txtSayi);
            Controls.Add(hesapla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button hesapla;
        private TextBox txtSayi;
        private Label label1;
        private Label lblkaresi;
        private Label label3;
    }
}
