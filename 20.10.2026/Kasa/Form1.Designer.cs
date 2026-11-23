namespace Kasa
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
            tekCek = new RadioButton();
            yuzde5_1 = new RadioButton();
            Yuzde5_2 = new RadioButton();
            Yuzde10_1 = new RadioButton();
            Yuzde10_2 = new RadioButton();
            groupBox1 = new GroupBox();
            txtgir = new TextBox();
            label1 = new Label();
            btnöde = new Button();
            lblson = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tekCek
            // 
            tekCek.AutoSize = true;
            tekCek.Location = new Point(6, 22);
            tekCek.Name = "tekCek";
            tekCek.Size = new Size(83, 19);
            tekCek.TabIndex = 0;
            tekCek.TabStop = true;
            tekCek.Text = "Tek Çekim";
            tekCek.UseVisualStyleBackColor = true;
            // 
            // yuzde5_1
            // 
            yuzde5_1.AutoSize = true;
            yuzde5_1.Location = new Point(6, 47);
            yuzde5_1.Name = "yuzde5_1";
            yuzde5_1.Size = new Size(140, 19);
            yuzde5_1.TabIndex = 0;
            yuzde5_1.TabStop = true;
            yuzde5_1.Text = "2 Taksit( %5 EK fiyat)";
            yuzde5_1.UseVisualStyleBackColor = true;
            // 
            // Yuzde5_2
            // 
            Yuzde5_2.AutoSize = true;
            Yuzde5_2.Location = new Point(6, 72);
            Yuzde5_2.Name = "Yuzde5_2";
            Yuzde5_2.Size = new Size(140, 19);
            Yuzde5_2.TabIndex = 0;
            Yuzde5_2.TabStop = true;
            Yuzde5_2.Text = "3 Taksit( %5 EK fiyat)";
            Yuzde5_2.UseVisualStyleBackColor = true;
            // 
            // Yuzde10_1
            // 
            Yuzde10_1.AutoSize = true;
            Yuzde10_1.Location = new Point(6, 97);
            Yuzde10_1.Name = "Yuzde10_1";
            Yuzde10_1.Size = new Size(147, 19);
            Yuzde10_1.TabIndex = 0;
            Yuzde10_1.TabStop = true;
            Yuzde10_1.Text = "4 Taksit( %10 EK fiyat)";
            Yuzde10_1.UseVisualStyleBackColor = true;
            // 
            // Yuzde10_2
            // 
            Yuzde10_2.AutoSize = true;
            Yuzde10_2.Location = new Point(6, 122);
            Yuzde10_2.Name = "Yuzde10_2";
            Yuzde10_2.Size = new Size(150, 19);
            Yuzde10_2.TabIndex = 0;
            Yuzde10_2.TabStop = true;
            Yuzde10_2.Text = "5 Taksit( % 10 EK fiyat)";
            Yuzde10_2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tekCek);
            groupBox1.Controls.Add(Yuzde10_2);
            groupBox1.Controls.Add(yuzde5_1);
            groupBox1.Controls.Add(Yuzde10_1);
            groupBox1.Controls.Add(Yuzde5_2);
            groupBox1.Location = new Point(102, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(168, 151);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ödeme Şekilleri";
            // 
            // txtgir
            // 
            txtgir.Location = new Point(151, 35);
            txtgir.Name = "txtgir";
            txtgir.Size = new Size(100, 23);
            txtgir.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 43);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 3;
            label1.Text = "Toplam Tutar:";
            // 
            // btnöde
            // 
            btnöde.Location = new Point(127, 234);
            btnöde.Name = "btnöde";
            btnöde.Size = new Size(103, 23);
            btnöde.TabIndex = 4;
            btnöde.Text = "Ödeme Yap";
            btnöde.UseVisualStyleBackColor = true;
            btnöde.Click += btnöde_Click;
            // 
            // lblson
            // 
            lblson.AutoSize = true;
            lblson.Location = new Point(72, 303);
            lblson.Name = "lblson";
            lblson.Size = new Size(0, 15);
            lblson.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(474, 458);
            Controls.Add(lblson);
            Controls.Add(btnöde);
            Controls.Add(label1);
            Controls.Add(txtgir);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "Form1";
            Text = "Kasa";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton tekCek;
        private RadioButton yuzde5_1;
        private RadioButton Yuzde5_2;
        private RadioButton Yuzde10_1;
        private RadioButton Yuzde10_2;
        private GroupBox groupBox1;
        private TextBox txtgir;
        private Label label1;
        private Button btnöde;
        private Label lblson;
    }
}
