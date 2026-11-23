namespace haftanın_günleri
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
            lblTarih = new Label();
            btnTarih = new Button();
            SuspendLayout();
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Location = new Point(131, 82);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(0, 15);
            lblTarih.TabIndex = 0;
            // 
            // btnTarih
            // 
            btnTarih.Location = new Point(84, 130);
            btnTarih.Name = "btnTarih";
            btnTarih.Size = new Size(109, 41);
            btnTarih.TabIndex = 1;
            btnTarih.Text = "Haftanın hangi günündeyiz?";
            btnTarih.UseVisualStyleBackColor = true;
            btnTarih.Click += btnTarih_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 345);
            Controls.Add(btnTarih);
            Controls.Add(lblTarih);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTarih;
        private Button btnTarih;
    }
}
