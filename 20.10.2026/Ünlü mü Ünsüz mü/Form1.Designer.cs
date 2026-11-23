namespace Ünlü_mü_Ünsüz_mü
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
            cmbBox = new ComboBox();
            lblson = new Label();
            btnSor = new Button();
            SuspendLayout();
            // 
            // cmbBox
            // 
            cmbBox.FormattingEnabled = true;
            cmbBox.Items.AddRange(new object[] { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" });
            cmbBox.Location = new Point(12, 12);
            cmbBox.Name = "cmbBox";
            cmbBox.Size = new Size(121, 23);
            cmbBox.TabIndex = 0;
            // 
            // lblson
            // 
            lblson.AutoSize = true;
            lblson.Location = new Point(23, 84);
            lblson.Name = "lblson";
            lblson.Size = new Size(0, 15);
            lblson.TabIndex = 1;
            // 
            // btnSor
            // 
            btnSor.Location = new Point(124, 148);
            btnSor.Name = "btnSor";
            btnSor.Size = new Size(75, 23);
            btnSor.TabIndex = 2;
            btnSor.Text = "Sorgula";
            btnSor.UseVisualStyleBackColor = true;
            btnSor.Click += btnSor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chartreuse;
            ClientSize = new Size(382, 194);
            Controls.Add(btnSor);
            Controls.Add(lblson);
            Controls.Add(cmbBox);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "Form1";
            Text = "Ünlü mü? Ünsüz mü?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBox;
        private Label lblson;
        private Button btnSor;
    }
}
