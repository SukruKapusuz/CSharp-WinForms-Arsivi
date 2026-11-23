namespace Donanım_Birimleri
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
            lsb = new ListBox();
            button1 = new Button();
            lblsonuc = new Label();
            SuspendLayout();
            // 
            // lsb
            // 
            lsb.FormattingEnabled = true;
            lsb.ItemHeight = 15;
            lsb.Items.AddRange(new object[] { "Mouse", "Yazıcı", "Klavye ", "Hoparlör", "Kamera", "Tarayıcı", "Projeksiyon" });
            lsb.Location = new Point(64, 73);
            lsb.Name = "lsb";
            lsb.Size = new Size(120, 94);
            lsb.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(109, 303);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Kontrol et";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblsonuc
            // 
            lblsonuc.AutoSize = true;
            lblsonuc.Location = new Point(54, 242);
            lblsonuc.Name = "lblsonuc";
            lblsonuc.Size = new Size(0, 15);
            lblsonuc.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 384);
            Controls.Add(lblsonuc);
            Controls.Add(button1);
            Controls.Add(lsb);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lsb;
        private Button button1;
        private Label lblsonuc;
    }
}
