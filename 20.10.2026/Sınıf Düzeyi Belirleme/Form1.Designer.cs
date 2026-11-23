namespace Sınıf_Düzeyi_Belirleme
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
            cmbSınıf = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbSınıf
            // 
            cmbSınıf.FormattingEnabled = true;
            cmbSınıf.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cmbSınıf.Location = new Point(80, 83);
            cmbSınıf.Name = "cmbSınıf";
            cmbSınıf.Size = new Size(121, 23);
            cmbSınıf.TabIndex = 0;
            cmbSınıf.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(45, 17);
            label1.Name = "label1";
            label1.Size = new Size(196, 19);
            label1.TabIndex = 1;
            label1.Text = "Hangi Eğitim Seviyesindesin";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(353, 223);
            Controls.Add(label1);
            Controls.Add(cmbSınıf);
            Name = "Form1";
            Text = "Eğitim Seviyesi Sorgula";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSınıf;
        private Label label1;
    }
}
