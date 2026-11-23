namespace _7_defa_yazdır
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
            lstyaz = new ListBox();
            btnyaz = new Button();
            SuspendLayout();
            // 
            // lstyaz
            // 
            lstyaz.FormattingEnabled = true;
            lstyaz.ItemHeight = 17;
            lstyaz.Location = new Point(75, 50);
            lstyaz.Name = "lstyaz";
            lstyaz.Size = new Size(192, 157);
            lstyaz.TabIndex = 0;
            // 
            // btnyaz
            // 
            btnyaz.Location = new Point(102, 230);
            btnyaz.Name = "btnyaz";
            btnyaz.Size = new Size(86, 26);
            btnyaz.TabIndex = 1;
            btnyaz.Text = "YAZDIR";
            btnyaz.UseVisualStyleBackColor = true;
            btnyaz.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(405, 393);
            Controls.Add(btnyaz);
            Controls.Add(lstyaz);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Name = "Form1";
            Text = "Yazdır";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstyaz;
        private Button btnyaz;
    }
}
