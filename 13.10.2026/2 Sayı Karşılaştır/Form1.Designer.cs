namespace _2_Sayı_Karşılaştır
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
            btnSor = new Button();
            lbl1 = new Label();
            label2 = new Label();
            txtBoxSayi1 = new TextBox();
            txtBoxSayi2 = new TextBox();
            SuspendLayout();
            // 
            // btnSor
            // 
            btnSor.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSor.Location = new Point(100, 148);
            btnSor.Name = "btnSor";
            btnSor.Size = new Size(75, 23);
            btnSor.TabIndex = 0;
            btnSor.Text = "Sor";
            btnSor.UseVisualStyleBackColor = true;
            btnSor.Click += btnSor_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            lbl1.Location = new Point(51, 47);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(45, 17);
            lbl1.TabIndex = 1;
            lbl1.Text = "Sayı 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            label2.Location = new Point(51, 92);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 2;
            label2.Text = "Sayı 2";
            // 
            // txtBoxSayi1
            // 
            txtBoxSayi1.Location = new Point(121, 41);
            txtBoxSayi1.Name = "txtBoxSayi1";
            txtBoxSayi1.Size = new Size(100, 23);
            txtBoxSayi1.TabIndex = 3;
            // 
            // txtBoxSayi2
            // 
            txtBoxSayi2.Location = new Point(121, 92);
            txtBoxSayi2.Name = "txtBoxSayi2";
            txtBoxSayi2.Size = new Size(100, 23);
            txtBoxSayi2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(309, 207);
            Controls.Add(txtBoxSayi2);
            Controls.Add(txtBoxSayi1);
            Controls.Add(label2);
            Controls.Add(lbl1);
            Controls.Add(btnSor);
            Name = "Form1";
            Text = "SAYI KAÇ DAHA BÜYÜK";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSor;
        private Label lbl1;
        private Label label2;
        private TextBox txtBoxSayi1;
        private TextBox txtBoxSayi2;
    }
}
