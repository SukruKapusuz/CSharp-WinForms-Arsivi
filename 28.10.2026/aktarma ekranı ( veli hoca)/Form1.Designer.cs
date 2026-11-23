namespace aktarma_ekranı___veli_hoca_
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
            txtSoy = new TextBox();
            lstbx1 = new ListBox();
            lstbx2 = new ListBox();
            cmb = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnKyd = new Button();
            btnAktar = new Button();
            btnTemizle = new Button();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(59, 57);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 0;
            // 
            // txtSoy
            // 
            txtSoy.Location = new Point(59, 128);
            txtSoy.Name = "txtSoy";
            txtSoy.Size = new Size(100, 23);
            txtSoy.TabIndex = 1;
            // 
            // lstbx1
            // 
            lstbx1.FormattingEnabled = true;
            lstbx1.ItemHeight = 15;
            lstbx1.Location = new Point(166, 56);
            lstbx1.Name = "lstbx1";
            lstbx1.Size = new Size(120, 94);
            lstbx1.TabIndex = 2;
            // 
            // lstbx2
            // 
            lstbx2.FormattingEnabled = true;
            lstbx2.ItemHeight = 15;
            lstbx2.Location = new Point(290, 57);
            lstbx2.Name = "lstbx2";
            lstbx2.Size = new Size(120, 94);
            lstbx2.TabIndex = 3;
            // 
            // cmb
            // 
            cmb.FormattingEnabled = true;
            cmb.Location = new Point(416, 57);
            cmb.Name = "cmb";
            cmb.Size = new Size(121, 23);
            cmb.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 60);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 6;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 128);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Soyad";
            // 
            // btnKyd
            // 
            btnKyd.Location = new Point(69, 157);
            btnKyd.Name = "btnKyd";
            btnKyd.Size = new Size(75, 23);
            btnKyd.TabIndex = 7;
            btnKyd.Text = "kaydet";
            btnKyd.UseVisualStyleBackColor = true;
            btnKyd.Click += btnKyd_Click;
            // 
            // btnAktar
            // 
            btnAktar.BackColor = Color.Transparent;
            btnAktar.Location = new Point(185, 157);
            btnAktar.Name = "btnAktar";
            btnAktar.Size = new Size(75, 23);
            btnAktar.TabIndex = 8;
            btnAktar.Text = "Aktar";
            btnAktar.UseVisualStyleBackColor = false;
            btnAktar.Click += btnAktar_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(228, 245);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(75, 23);
            btnTemizle.TabIndex = 9;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.YellowGreen;
            ClientSize = new Size(592, 361);
            Controls.Add(btnTemizle);
            Controls.Add(btnAktar);
            Controls.Add(btnKyd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmb);
            Controls.Add(lstbx2);
            Controls.Add(lstbx1);
            Controls.Add(txtSoy);
            Controls.Add(txtAd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private TextBox txtSoy;
        private ListBox lstbx1;
        private ListBox lstbx2;
        private ComboBox cmb;
        private Label label1;
        private Label label2;
        private Button btnKyd;
        private Button btnAktar;
        private Button btnTemizle;
    }
}
