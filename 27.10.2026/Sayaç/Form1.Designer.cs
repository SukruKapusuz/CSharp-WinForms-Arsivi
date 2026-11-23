namespace Sayaç
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
            btnEksi = new Button();
            btnArti = new Button();
            txtSayi = new TextBox();
            SuspendLayout();
            // 
            // btnEksi
            // 
            btnEksi.Location = new Point(45, 64);
            btnEksi.Margin = new Padding(4, 4, 4, 4);
            btnEksi.Name = "btnEksi";
            btnEksi.Size = new Size(74, 63);
            btnEksi.TabIndex = 0;
            btnEksi.Text = "-1";
            btnEksi.UseVisualStyleBackColor = true;
            btnEksi.Click += btnEksi_Click;
            // 
            // btnArti
            // 
            btnArti.Location = new Point(266, 64);
            btnArti.Margin = new Padding(4, 4, 4, 4);
            btnArti.Name = "btnArti";
            btnArti.Size = new Size(81, 63);
            btnArti.TabIndex = 1;
            btnArti.Text = "+1";
            btnArti.UseVisualStyleBackColor = true;
            btnArti.Click += btnArti_Click;
            // 
            // txtSayi
            // 
            txtSayi.Location = new Point(127, 79);
            txtSayi.Margin = new Padding(4, 4, 4, 4);
            txtSayi.Name = "txtSayi";
            txtSayi.Size = new Size(128, 29);
            txtSayi.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(401, 191);
            Controls.Add(txtSayi);
            Controls.Add(btnArti);
            Controls.Add(btnEksi);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEksi;
        private Button btnArti;
        private TextBox txtSayi;
    }
}
