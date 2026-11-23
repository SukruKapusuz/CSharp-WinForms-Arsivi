namespace Alışveriş_İndirim_Hesaplaması
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
            label1 = new Label();
            Girdiler = new GroupBox();
            chcBoxSadaka = new CheckBox();
            chcBoxOgrenci = new CheckBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            btnHesapla = new Button();
            groupBox1 = new GroupBox();
            label9 = new Label();
            lblSadakatİndir = new Label();
            lblogrenciİndir = new Label();
            label6 = new Label();
            brutTutar = new Label();
            lblNetTutar = new Label();
            label4 = new Label();
            Girdiler.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 19);
            label1.TabIndex = 0;
            label1.Text = "C# Öğrenci Uygulaması";
            // 
            // Girdiler
            // 
            Girdiler.Controls.Add(chcBoxSadaka);
            Girdiler.Controls.Add(chcBoxOgrenci);
            Girdiler.Controls.Add(label3);
            Girdiler.Controls.Add(textBox1);
            Girdiler.Controls.Add(label2);
            Girdiler.Location = new Point(12, 31);
            Girdiler.Name = "Girdiler";
            Girdiler.Size = new Size(363, 261);
            Girdiler.TabIndex = 1;
            Girdiler.TabStop = false;
            Girdiler.Text = "Girdiler";
            // 
            // chcBoxSadaka
            // 
            chcBoxSadaka.AutoSize = true;
            chcBoxSadaka.Font = new Font("Segoe UI", 15F);
            chcBoxSadaka.Location = new Point(26, 164);
            chcBoxSadaka.Name = "chcBoxSadaka";
            chcBoxSadaka.Size = new Size(202, 32);
            chcBoxSadaka.TabIndex = 4;
            chcBoxSadaka.Text = "Sadakat Kartı (%10)";
            chcBoxSadaka.UseVisualStyleBackColor = true;
            // 
            // chcBoxOgrenci
            // 
            chcBoxOgrenci.AutoSize = true;
            chcBoxOgrenci.Font = new Font("Segoe UI", 15F);
            chcBoxOgrenci.Location = new Point(26, 128);
            chcBoxOgrenci.Name = "chcBoxOgrenci";
            chcBoxOgrenci.Size = new Size(263, 32);
            chcBoxOgrenci.TabIndex = 3;
            chcBoxOgrenci.Text = "Öğrenci Kartı İndirim(%10)";
            chcBoxOgrenci.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(30, 92);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 2;
            label3.Text = "İndirimler";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(6, 38);
            label2.Name = "label2";
            label2.Size = new Size(162, 28);
            label2.TabIndex = 0;
            label2.Text = "Toplam Tutar (TL)";
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(38, 314);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(304, 50);
            btnHesapla.TabIndex = 2;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lblSadakatİndir);
            groupBox1.Controls.Add(lblogrenciİndir);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(brutTutar);
            groupBox1.Controls.Add(lblNetTutar);
            groupBox1.Controls.Add(label4);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(381, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 333);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hesaplama Sonuçları";
            groupBox1.Enter += hesapsonuc_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 256);
            label9.Name = "label9";
            label9.Size = new Size(91, 15);
            label9.TabIndex = 6;
            label9.Text = "Toplam İndirim:";
            // 
            // lblSadakatİndir
            // 
            lblSadakatİndir.AutoSize = true;
            lblSadakatİndir.Location = new Point(23, 228);
            lblSadakatİndir.Name = "lblSadakatİndir";
            lblSadakatİndir.Size = new Size(123, 15);
            lblSadakatİndir.TabIndex = 5;
            lblSadakatİndir.Text = "-Sadakat kart İndirimi:";
            // 
            // lblogrenciİndir
            // 
            lblogrenciİndir.AutoSize = true;
            lblogrenciİndir.Location = new Point(23, 197);
            lblogrenciİndir.Name = "lblogrenciİndir";
            lblogrenciİndir.Size = new Size(101, 15);
            lblogrenciİndir.TabIndex = 4;
            lblogrenciİndir.Text = "-Öğrenci İndirimi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 164);
            label6.Name = "label6";
            label6.Size = new Size(118, 15);
            label6.TabIndex = 3;
            label6.Text = "Uygulanan İndirimler";
            // 
            // brutTutar
            // 
            brutTutar.AutoSize = true;
            brutTutar.BackColor = SystemColors.ControlLightLight;
            brutTutar.Location = new Point(23, 131);
            brutTutar.Name = "brutTutar";
            brutTutar.Size = new Size(66, 15);
            brutTutar.TabIndex = 2;
            brutTutar.Text = "Brüt Tutar :";
            // 
            // lblNetTutar
            // 
            lblNetTutar.AutoSize = true;
            lblNetTutar.Location = new Point(76, 80);
            lblNetTutar.Name = "lblNetTutar";
            lblNetTutar.Size = new Size(0, 15);
            lblNetTutar.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(15, 29);
            label4.Name = "label4";
            label4.Size = new Size(253, 31);
            label4.TabIndex = 0;
            label4.Text = "Ödenecek Net Nutar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 393);
            Controls.Add(groupBox1);
            Controls.Add(btnHesapla);
            Controls.Add(Girdiler);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Girdiler.ResumeLayout(false);
            Girdiler.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox Girdiler;
        private CheckBox chcBoxSadaka;
        private CheckBox chcBoxOgrenci;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Button btnHesapla;
        private GroupBox groupBox1;
        private Label lblNetTutar;
        private Label label4;
        private Label brutTutar;
        private Label label9;
        private Label lblSadakatİndir;
        private Label lblogrenciİndir;
        private Label label6;
    }
}
