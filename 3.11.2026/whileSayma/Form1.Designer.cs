namespace whileSayma
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
            lstYaz = new ListBox();
            SuspendLayout();
            // 
            // btnYaz
            // 
            btnYaz.Location = new Point(72, 258);
            btnYaz.Name = "btnYaz";
            btnYaz.Size = new Size(86, 26);
            btnYaz.TabIndex = 0;
            btnYaz.Text = "Yazdır";
            btnYaz.UseVisualStyleBackColor = true;
            btnYaz.Click += btnYaz_Click;
            // 
            // lstYaz
            // 
            lstYaz.FormattingEnabled = true;
            lstYaz.ItemHeight = 17;
            lstYaz.Location = new Point(12, 12);
            lstYaz.Name = "lstYaz";
            lstYaz.Size = new Size(214, 208);
            lstYaz.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chartreuse;
            ClientSize = new Size(245, 329);
            Controls.Add(lstYaz);
            Controls.Add(btnYaz);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnYaz;
        private ListBox lstYaz;
    }
}
