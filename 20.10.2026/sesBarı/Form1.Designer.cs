namespace sesBarı
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
            trackBar1 = new TrackBar();
            lblcıktı = new Label();
            lblseviye = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(37, 63);
            trackBar1.Maximum = 15;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(245, 45);
            trackBar1.TabIndex = 0;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // lblcıktı
            // 
            lblcıktı.AutoSize = true;
            lblcıktı.Location = new Point(53, 177);
            lblcıktı.Name = "lblcıktı";
            lblcıktı.Size = new Size(0, 19);
            lblcıktı.TabIndex = 1;
            // 
            // lblseviye
            // 
            lblseviye.AutoSize = true;
            lblseviye.Location = new Point(53, 121);
            lblseviye.Name = "lblseviye";
            lblseviye.Size = new Size(0, 19);
            lblseviye.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(335, 261);
            Controls.Add(lblseviye);
            Controls.Add(lblcıktı);
            Controls.Add(trackBar1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Name = "Form1";
            Text = "Ses seviyesi";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar1;
        private Label lblcıktı;
        private Label lblseviye;
    }
}
