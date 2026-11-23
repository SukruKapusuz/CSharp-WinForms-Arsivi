namespace girisEkranı___Soru1_
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
            txtAd = new TextBox();
            txtSifre = new TextBox();
            lbl1 = new Label();
            label2 = new Label();
            btnSor = new Button();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(119, 25);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(119, 53);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(100, 23);
            txtSifre.TabIndex = 1;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(40, 28);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(73, 15);
            lbl1.TabIndex = 2;
            lbl1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 56);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 3;
            label2.Text = "Şifre";
            // 
            // btnSor
            // 
            btnSor.Location = new Point(93, 126);
            btnSor.Name = "btnSor";
            btnSor.Size = new Size(75, 23);
            btnSor.TabIndex = 4;
            btnSor.Text = "Sorgula";
            btnSor.UseVisualStyleBackColor = true;
            btnSor.Click += btnSor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 185);
            Controls.Add(btnSor);
            Controls.Add(label2);
            Controls.Add(lbl1);
            Controls.Add(txtSifre);
            Controls.Add(txtAd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private TextBox txtSifre;
        private Label lbl1;
        private Label label2;
        private Button btnSor;
    }
}
