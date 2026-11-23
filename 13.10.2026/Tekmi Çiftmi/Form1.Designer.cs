namespace Tekmi_Çiftmi
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
            lbl1 = new Label();
            btnSorgula = new Button();
            txtBoxSayi = new TextBox();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lbl1.Location = new Point(67, 63);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(108, 19);
            lbl1.TabIndex = 0;
            lbl1.Text = "Tek mi çift mi?";
            // 
            // btnSorgula
            // 
            btnSorgula.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSorgula.Location = new Point(75, 112);
            btnSorgula.Name = "btnSorgula";
            btnSorgula.Size = new Size(100, 28);
            btnSorgula.TabIndex = 1;
            btnSorgula.Text = "Sor";
            btnSorgula.UseVisualStyleBackColor = true;
            btnSorgula.Click += btnSorgula_Click;
            // 
            // txtBoxSayi
            // 
            txtBoxSayi.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            txtBoxSayi.Location = new Point(75, 85);
            txtBoxSayi.Name = "txtBoxSayi";
            txtBoxSayi.Size = new Size(100, 21);
            txtBoxSayi.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSpringGreen;
            ClientSize = new Size(262, 237);
            Controls.Add(txtBoxSayi);
            Controls.Add(btnSorgula);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "TEK Mİ ÇİFT Mİ?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Button btnSorgula;
        private TextBox txtBoxSayi;
    }
}
