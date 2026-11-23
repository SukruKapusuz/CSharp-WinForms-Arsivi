namespace NetHesapla
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            hesapla = new Button();
            txtMatematikNet = new TextBox();
            txtTurkceNet = new TextBox();
            txtMatematikYanlis = new TextBox();
            txtTurkceYanlis = new TextBox();
            txtMatematikDogru = new TextBox();
            txtTurkceDogru = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 100);
            label1.Name = "label1";
            label1.Size = new Size(125, 19);
            label1.TabIndex = 0;
            label1.Text = "Türkçe (40 SORU)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 151);
            label2.Name = "label2";
            label2.Size = new Size(153, 19);
            label2.TabIndex = 1;
            label2.Text = "Matematik (40 SORU)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(215, 56);
            label3.Name = "label3";
            label3.Size = new Size(51, 19);
            label3.TabIndex = 2;
            label3.Text = "Doğru";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(284, 56);
            label4.Name = "label4";
            label4.Size = new Size(47, 19);
            label4.TabIndex = 3;
            label4.Text = "Yanlış";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(356, 56);
            label5.Name = "label5";
            label5.Size = new Size(33, 19);
            label5.TabIndex = 4;
            label5.Text = "Net";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(hesapla);
            groupBox1.Controls.Add(txtMatematikNet);
            groupBox1.Controls.Add(txtTurkceNet);
            groupBox1.Controls.Add(txtMatematikYanlis);
            groupBox1.Controls.Add(txtTurkceYanlis);
            groupBox1.Controls.Add(txtMatematikDogru);
            groupBox1.Controls.Add(txtTurkceDogru);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(488, 285);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sınav 1. Oturum";
            // 
            // hesapla
            // 
            hesapla.Location = new Point(186, 223);
            hesapla.Name = "hesapla";
            hesapla.Size = new Size(225, 39);
            hesapla.TabIndex = 6;
            hesapla.Text = "Net Hesapla";
            hesapla.UseVisualStyleBackColor = true;
            hesapla.Click += hesapla_Click;
            // 
            // txtMatematikNet
            // 
            txtMatematikNet.Font = new Font("Segoe UI", 10F);
            txtMatematikNet.Location = new Point(356, 145);
            txtMatematikNet.Name = "txtMatematikNet";
            txtMatematikNet.Size = new Size(40, 25);
            txtMatematikNet.TabIndex = 5;
            // 
            // txtTurkceNet
            // 
            txtTurkceNet.Font = new Font("Segoe UI", 10F);
            txtTurkceNet.Location = new Point(356, 94);
            txtTurkceNet.Name = "txtTurkceNet";
            txtTurkceNet.Size = new Size(40, 25);
            txtTurkceNet.TabIndex = 5;
            // 
            // txtMatematikYanlis
            // 
            txtMatematikYanlis.Font = new Font("Segoe UI", 10F);
            txtMatematikYanlis.Location = new Point(284, 145);
            txtMatematikYanlis.Name = "txtMatematikYanlis";
            txtMatematikYanlis.Size = new Size(40, 25);
            txtMatematikYanlis.TabIndex = 5;
            // 
            // txtTurkceYanlis
            // 
            txtTurkceYanlis.Font = new Font("Segoe UI", 10F);
            txtTurkceYanlis.Location = new Point(284, 94);
            txtTurkceYanlis.Name = "txtTurkceYanlis";
            txtTurkceYanlis.Size = new Size(40, 25);
            txtTurkceYanlis.TabIndex = 5;
            // 
            // txtMatematikDogru
            // 
            txtMatematikDogru.Font = new Font("Segoe UI", 10F);
            txtMatematikDogru.Location = new Point(215, 145);
            txtMatematikDogru.Name = "txtMatematikDogru";
            txtMatematikDogru.Size = new Size(40, 25);
            txtMatematikDogru.TabIndex = 5;
            // 
            // txtTurkceDogru
            // 
            txtTurkceDogru.Font = new Font("Segoe UI", 10F);
            txtTurkceDogru.Location = new Point(215, 94);
            txtTurkceDogru.Name = "txtTurkceDogru";
            txtTurkceDogru.Size = new Size(40, 25);
            txtTurkceDogru.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(512, 309);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox txtMatematikNet;
        private TextBox txtTurkceNet;
        private TextBox txtMatematikYanlis;
        private TextBox txtTurkceYanlis;
        private TextBox txtMatematikDogru;
        private TextBox txtTurkceDogru;
        private Button hesapla;
    }
}
