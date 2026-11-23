namespace AtYarışı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            at1 = new PictureBox();
            btnNormal1 = new Button();
            btnNormal2 = new Button();
            btnHizli2 = new Button();
            btnHizli1 = new Button();
            btnSıfırla = new Button();
            at2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)at1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)at2).BeginInit();
            SuspendLayout();
            // 
            // at1
            // 
            at1.Image = (Image)resources.GetObject("at1.Image");
            at1.Location = new Point(14, 40);
            at1.Name = "at1";
            at1.Size = new Size(176, 93);
            at1.SizeMode = PictureBoxSizeMode.StretchImage;
            at1.TabIndex = 0;
            at1.TabStop = false;
            // 
            // btnNormal1
            // 
            btnNormal1.Location = new Point(678, 74);
            btnNormal1.Name = "btnNormal1";
            btnNormal1.Size = new Size(86, 26);
            btnNormal1.TabIndex = 2;
            btnNormal1.Text = "Normal";
            btnNormal1.UseVisualStyleBackColor = true;
            btnNormal1.Click += btnNormal1_Click;
            // 
            // btnNormal2
            // 
            btnNormal2.Location = new Point(678, 194);
            btnNormal2.Name = "btnNormal2";
            btnNormal2.Size = new Size(86, 26);
            btnNormal2.TabIndex = 2;
            btnNormal2.Text = "Normal";
            btnNormal2.UseVisualStyleBackColor = true;
            btnNormal2.Click += btnNormal2_Click;
            // 
            // btnHizli2
            // 
            btnHizli2.Location = new Point(770, 194);
            btnHizli2.Name = "btnHizli2";
            btnHizli2.Size = new Size(86, 26);
            btnHizli2.TabIndex = 2;
            btnHizli2.Text = "Hızlı";
            btnHizli2.UseVisualStyleBackColor = true;
            btnHizli2.Click += btnHizli2_Click;
            // 
            // btnHizli1
            // 
            btnHizli1.Location = new Point(770, 74);
            btnHizli1.Name = "btnHizli1";
            btnHizli1.Size = new Size(86, 26);
            btnHizli1.TabIndex = 2;
            btnHizli1.Text = "Hızlı";
            btnHizli1.UseVisualStyleBackColor = true;
            btnHizli1.Click += btnHizli1_Click;
            // 
            // btnSıfırla
            // 
            btnSıfırla.Location = new Point(360, 354);
            btnSıfırla.Name = "btnSıfırla";
            btnSıfırla.Size = new Size(86, 26);
            btnSıfırla.TabIndex = 3;
            btnSıfırla.Text = "Sıfırla";
            btnSıfırla.UseVisualStyleBackColor = true;
            btnSıfırla.Click += btnSıfırla_Click;
            // 
            // at2
            // 
            at2.Image = (Image)resources.GetObject("at2.Image");
            at2.Location = new Point(14, 170);
            at2.Name = "at2";
            at2.Size = new Size(176, 93);
            at2.SizeMode = PictureBoxSizeMode.StretchImage;
            at2.TabIndex = 0;
            at2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 18);
            label1.Name = "label1";
            label1.Size = new Size(669, 19);
            label1.TabIndex = 4;
            label1.Text = "--------------------------------------------------------------------------------------------------------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 136);
            label2.Name = "label2";
            label2.Size = new Size(669, 19);
            label2.TabIndex = 4;
            label2.Text = "--------------------------------------------------------------------------------------------------------------";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 266);
            label3.Name = "label3";
            label3.Size = new Size(669, 19);
            label3.TabIndex = 4;
            label3.Text = "--------------------------------------------------------------------------------------------------------------";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 422);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSıfırla);
            Controls.Add(btnHizli1);
            Controls.Add(btnHizli2);
            Controls.Add(btnNormal2);
            Controls.Add(btnNormal1);
            Controls.Add(at2);
            Controls.Add(at1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)at1).EndInit();
            ((System.ComponentModel.ISupportInitialize)at2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox at1;
        private Button btnNormal1;
        private Button btnNormal2;
        private Button btnHizli2;
        private Button btnHizli1;
        private Button btnSıfırla;
        private PictureBox at2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
