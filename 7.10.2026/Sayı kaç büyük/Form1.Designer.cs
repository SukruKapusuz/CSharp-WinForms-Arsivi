namespace Sayı_kaç_büyük
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
            btnKontrol = new Button();
            txtSayi1 = new TextBox();
            txtSayi2 = new TextBox();
            lbl1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnKontrol
            // 
            btnKontrol.Location = new Point(148, 193);
            btnKontrol.Name = "btnKontrol";
            btnKontrol.Size = new Size(123, 23);
            btnKontrol.TabIndex = 0;
            btnKontrol.Text = "Hangisi büyük?";
            btnKontrol.UseVisualStyleBackColor = true;
            btnKontrol.Click += btnKontrol_Click;
            // 
            // txtSayi1
            // 
            txtSayi1.Location = new Point(85, 104);
            txtSayi1.Name = "txtSayi1";
            txtSayi1.Size = new Size(100, 23);
            txtSayi1.TabIndex = 1;
            // 
            // txtSayi2
            // 
            txtSayi2.Location = new Point(255, 104);
            txtSayi2.Name = "txtSayi2";
            txtSayi2.Size = new Size(100, 23);
            txtSayi2.TabIndex = 2;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(97, 64);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(34, 15);
            lbl1.TabIndex = 3;
            lbl1.Text = "Sayı1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 64);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 4;
            label2.Text = "Sayı2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(436, 345);
            Controls.Add(label2);
            Controls.Add(lbl1);
            Controls.Add(txtSayi2);
            Controls.Add(txtSayi1);
            Controls.Add(btnKontrol);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKontrol;
        private TextBox txtSayi1;
        private TextBox txtSayi2;
        private Label lbl1;
        private Label label2;
    }
}
