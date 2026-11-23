namespace En_büyük_en_küçük
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
            txtBox1 = new TextBox();
            txtBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBox3 = new TextBox();
            btnBuyuk = new Button();
            btnKucuk = new Button();
            lblEnBuyuk = new Label();
            lblEnKucuk = new Label();
            SuspendLayout();
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(136, 42);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(100, 23);
            txtBox1.TabIndex = 0;
            // 
            // txtBox2
            // 
            txtBox2.Location = new Point(136, 98);
            txtBox2.Name = "txtBox2";
            txtBox2.Size = new Size(100, 23);
            txtBox2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 50);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Sayı 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 98);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Sayı 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 153);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 1;
            label3.Text = "Sayı 3 ";
            // 
            // txtBox3
            // 
            txtBox3.Location = new Point(136, 150);
            txtBox3.Name = "txtBox3";
            txtBox3.Size = new Size(100, 23);
            txtBox3.TabIndex = 0;
            // 
            // btnBuyuk
            // 
            btnBuyuk.Location = new Point(57, 219);
            btnBuyuk.Name = "btnBuyuk";
            btnBuyuk.Size = new Size(75, 23);
            btnBuyuk.TabIndex = 2;
            btnBuyuk.Text = "En büyük";
            btnBuyuk.UseVisualStyleBackColor = true;
            btnBuyuk.Click += btnBuyuk_Click;
            // 
            // btnKucuk
            // 
            btnKucuk.Location = new Point(179, 219);
            btnKucuk.Name = "btnKucuk";
            btnKucuk.Size = new Size(75, 23);
            btnKucuk.TabIndex = 3;
            btnKucuk.Text = "En Düşük";
            btnKucuk.UseVisualStyleBackColor = true;
            btnKucuk.Click += btnKucuk_Click;
            // 
            // lblEnBuyuk
            // 
            lblEnBuyuk.AutoSize = true;
            lblEnBuyuk.Location = new Point(71, 294);
            lblEnBuyuk.Name = "lblEnBuyuk";
            lblEnBuyuk.Size = new Size(0, 15);
            lblEnBuyuk.TabIndex = 1;
            // 
            // lblEnKucuk
            // 
            lblEnKucuk.AutoSize = true;
            lblEnKucuk.Location = new Point(196, 294);
            lblEnKucuk.Name = "lblEnKucuk";
            lblEnKucuk.Size = new Size(0, 15);
            lblEnKucuk.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(362, 327);
            Controls.Add(lblEnKucuk);
            Controls.Add(btnKucuk);
            Controls.Add(btnBuyuk);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblEnBuyuk);
            Controls.Add(label1);
            Controls.Add(txtBox3);
            Controls.Add(txtBox2);
            Controls.Add(txtBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "Form1";
            Text = "Sayı Sıralama";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox1;
        private TextBox txtBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBox3;
        private Button btnBuyuk;
        private Button btnKucuk;
        private Label lblEnBuyuk;
        private Label lblEnKucuk;
    }
}
