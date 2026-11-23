namespace _100_e_kadar_while
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
            btnyaz = new Button();
            lstyaz = new ListBox();
            SuspendLayout();
            // 
            // btnyaz
            // 
            btnyaz.Location = new Point(105, 302);
            btnyaz.Name = "btnyaz";
            btnyaz.Size = new Size(86, 26);
            btnyaz.TabIndex = 0;
            btnyaz.Text = "Yazdır";
            btnyaz.UseVisualStyleBackColor = true;
            btnyaz.Click += btnyaz_Click;
            // 
            // lstyaz
            // 
            lstyaz.FormattingEnabled = true;
            lstyaz.ItemHeight = 17;
            lstyaz.Location = new Point(14, 14);
            lstyaz.Name = "lstyaz";
            lstyaz.Size = new Size(287, 242);
            lstyaz.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(318, 374);
            Controls.Add(lstyaz);
            Controls.Add(btnyaz);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnyaz;
        private ListBox lstyaz;
    }
}
