namespace HesapMakinesi
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
            btn_topla = new Button();
            btn_cıkar = new Button();
            btn_carp = new Button();
            btn_bol = new Button();
            lblsayı1 = new Label();
            lbl2 = new Label();
            label3 = new Label();
            sonuc = new Label();
            txt1 = new TextBox();
            txt2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn_topla
            // 
            btn_topla.Location = new Point(64, 142);
            btn_topla.Name = "btn_topla";
            btn_topla.Size = new Size(75, 23);
            btn_topla.TabIndex = 0;
            btn_topla.Text = "topla";
            btn_topla.UseVisualStyleBackColor = true;
            btn_topla.Click += Topla_Click;
            // 
            // btn_cıkar
            // 
            btn_cıkar.Location = new Point(168, 142);
            btn_cıkar.Name = "btn_cıkar";
            btn_cıkar.Size = new Size(75, 23);
            btn_cıkar.TabIndex = 1;
            btn_cıkar.Text = "çıkart";
            btn_cıkar.UseVisualStyleBackColor = true;
            btn_cıkar.Click += çıkar_Click;
            // 
            // btn_carp
            // 
            btn_carp.Location = new Point(64, 171);
            btn_carp.Name = "btn_carp";
            btn_carp.Size = new Size(75, 23);
            btn_carp.TabIndex = 2;
            btn_carp.Text = "çarp";
            btn_carp.UseVisualStyleBackColor = true;
            btn_carp.Click += carp_Click;
            // 
            // btn_bol
            // 
            btn_bol.Location = new Point(168, 171);
            btn_bol.Name = "btn_bol";
            btn_bol.Size = new Size(75, 23);
            btn_bol.TabIndex = 3;
            btn_bol.Text = "bölme";
            btn_bol.UseVisualStyleBackColor = true;
            btn_bol.Click += böl_Click;
            // 
            // lblsayı1
            // 
            lblsayı1.AutoSize = true;
            lblsayı1.Location = new Point(64, 62);
            lblsayı1.Name = "lblsayı1";
            lblsayı1.Size = new Size(34, 15);
            lblsayı1.TabIndex = 5;
            lblsayı1.Text = "Sayı1";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(64, 99);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(34, 15);
            lbl2.TabIndex = 6;
            lbl2.Text = "Sayı2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 248);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 7;
            label3.Text = "Sonuç:";
            // 
            // sonuc
            // 
            sonuc.AutoSize = true;
            sonuc.Location = new Point(168, 248);
            sonuc.Name = "sonuc";
            sonuc.Size = new Size(0, 15);
            sonuc.TabIndex = 8;
            // 
            // txt1
            // 
            txt1.Location = new Point(145, 67);
            txt1.Name = "txt1";
            txt1.Size = new Size(100, 23);
            txt1.TabIndex = 12;
            // 
            // txt2
            // 
            txt2.Location = new Point(145, 96);
            txt2.Name = "txt2";
            txt2.Size = new Size(100, 23);
            txt2.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "temizle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GreenYellow;
            ClientSize = new Size(327, 344);
            Controls.Add(button1);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(sonuc);
            Controls.Add(label3);
            Controls.Add(lbl2);
            Controls.Add(lblsayı1);
            Controls.Add(btn_bol);
            Controls.Add(btn_carp);
            Controls.Add(btn_cıkar);
            Controls.Add(btn_topla);
            Name = "Form1";
            Text = "Temizle";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_topla;
        private Button btn_cıkar;
        private Button btn_carp;
        private Button btn_bol;
        private Label lblsayı1;
        private Label lbl2;
        private Label label3;
        private Label sonuc;
        private TextBox txt1;
        private TextBox txt2;
        private Button button1;
    }
}
