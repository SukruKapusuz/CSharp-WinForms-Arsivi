namespace _15.uygulama
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
            lblfiyat = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblfiyat
            // 
            lblfiyat.AutoSize = true;
            lblfiyat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblfiyat.Location = new Point(27, 60);
            lblfiyat.Name = "lblfiyat";
            lblfiyat.Size = new Size(72, 15);
            lblfiyat.TabIndex = 0;
            lblfiyat.Text = "Etiket Fiyatı";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox1.Location = new Point(206, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(24, 111);
            button1.Name = "button1";
            button1.Size = new Size(75, 55);
            button1.TabIndex = 2;
            button1.Text = "Yüzde 10 İndirim";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(105, 111);
            button2.Name = "button2";
            button2.Size = new Size(75, 55);
            button2.TabIndex = 2;
            button2.Text = "Yüzde 25 İndirim";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(186, 111);
            button3.Name = "button3";
            button3.Size = new Size(75, 55);
            button3.TabIndex = 2;
            button3.Text = "Yüzde 50 İndirim";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 0, 0);
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(267, 111);
            button4.Name = "button4";
            button4.Size = new Size(75, 55);
            button4.TabIndex = 2;
            button4.Text = "Yüzde 75 İndirim";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(36, 221);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 3;
            label2.Text = "İndirimli Fiyatı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(160, 221);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 284);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(lblfiyat);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblfiyat;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private Label label3;
    }
}
