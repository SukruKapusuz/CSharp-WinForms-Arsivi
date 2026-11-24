namespace ClassİleHesaplama.Formlar
{
    partial class Dikdortgen
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
            txtUzun = new TextBox();
            txtKisa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnAlan = new Button();
            btnCevre = new Button();
            label3 = new Label();
            label4 = new Label();
            lblCevre = new Label();
            lblAlan = new Label();
            SuspendLayout();
            // 
            // txtUzun
            // 
            txtUzun.Location = new Point(97, 41);
            txtUzun.Name = "txtUzun";
            txtUzun.Size = new Size(100, 23);
            txtUzun.TabIndex = 0;
            // 
            // txtKisa
            // 
            txtKisa.Location = new Point(97, 77);
            txtKisa.Name = "txtKisa";
            txtKisa.Size = new Size(100, 23);
            txtKisa.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 38);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "Uzun Kenar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 85);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Kısa Kenar";
            // 
            // btnAlan
            // 
            btnAlan.Location = new Point(74, 134);
            btnAlan.Name = "btnAlan";
            btnAlan.Size = new Size(123, 23);
            btnAlan.TabIndex = 2;
            btnAlan.Text = "Hesapla Alan";
            btnAlan.UseVisualStyleBackColor = true;
            btnAlan.Click += btnAlan_Click;
            // 
            // btnCevre
            // 
            btnCevre.Location = new Point(74, 163);
            btnCevre.Name = "btnCevre";
            btnCevre.Size = new Size(123, 23);
            btnCevre.TabIndex = 2;
            btnCevre.Text = "Hesapla Çevre";
            btnCevre.UseVisualStyleBackColor = true;
            btnCevre.Click += btnCevre_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 40);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 3;
            label3.Text = "Alan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(224, 77);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 3;
            label4.Text = "Çevre";
            // 
            // lblCevre
            // 
            lblCevre.AutoSize = true;
            lblCevre.Location = new Point(282, 77);
            lblCevre.Name = "lblCevre";
            lblCevre.Size = new Size(0, 15);
            lblCevre.TabIndex = 3;
            // 
            // lblAlan
            // 
            lblAlan.AutoSize = true;
            lblAlan.Location = new Point(282, 40);
            lblAlan.Name = "lblAlan";
            lblAlan.Size = new Size(0, 15);
            lblAlan.TabIndex = 3;
            // 
            // Dikdortgen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GreenYellow;
            ClientSize = new Size(439, 263);
            Controls.Add(lblAlan);
            Controls.Add(lblCevre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnCevre);
            Controls.Add(btnAlan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtKisa);
            Controls.Add(txtUzun);
            Name = "Dikdortgen";
            Text = "formDikdortgen";
            FormClosed += Dikdortgen_FormClosed;
            Load += Dikdortgen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUzun;
        private TextBox txtKisa;
        private Label label1;
        private Label label2;
        private Button btnAlan;
        private Button btnCevre;
        private Label label3;
        private Label label4;
        private Label lblCevre;
        private Label lblAlan;
    }
}