namespace classDenemesi
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
            txtUzun = new TextBox();
            txtKisa = new TextBox();
            btnHesap = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtUzun
            // 
            txtUzun.Location = new Point(115, 60);
            txtUzun.Name = "txtUzun";
            txtUzun.Size = new Size(100, 23);
            txtUzun.TabIndex = 0;
            // 
            // txtKisa
            // 
            txtKisa.Location = new Point(115, 119);
            txtKisa.Name = "txtKisa";
            txtKisa.Size = new Size(100, 23);
            txtKisa.TabIndex = 0;
            // 
            // btnHesap
            // 
            btnHesap.Location = new Point(148, 179);
            btnHesap.Name = "btnHesap";
            btnHesap.Size = new Size(75, 23);
            btnHesap.TabIndex = 1;
            btnHesap.Text = "Hesapla";
            btnHesap.UseVisualStyleBackColor = true;
            btnHesap.Click += btnHesap_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 27);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnHesap);
            Controls.Add(txtKisa);
            Controls.Add(txtUzun);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUzun;
        private TextBox txtKisa;
        private Button btnHesap;
        private Label label1;
    }
}
