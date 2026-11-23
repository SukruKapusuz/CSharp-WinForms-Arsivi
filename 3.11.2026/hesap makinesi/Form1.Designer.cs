namespace hesap_makinesi
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
            btnYaz = new Button();
            lsthesap = new ListBox();
            SuspendLayout();
            // 
            // btnYaz
            // 
            btnYaz.Location = new Point(452, 149);
            btnYaz.Name = "btnYaz";
            btnYaz.Size = new Size(75, 23);
            btnYaz.TabIndex = 0;
            btnYaz.Text = "Yazdır";
            btnYaz.UseVisualStyleBackColor = true;
            btnYaz.Click += btnYaz_Click;
            // 
            // lsthesap
            // 
            lsthesap.FormattingEnabled = true;
            lsthesap.ItemHeight = 15;
            lsthesap.Location = new Point(12, 12);
            lsthesap.Name = "lsthesap";
            lsthesap.Size = new Size(400, 469);
            lsthesap.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(563, 528);
            Controls.Add(lsthesap);
            Controls.Add(btnYaz);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnYaz;
        private ListBox lsthesap;
    }
}
