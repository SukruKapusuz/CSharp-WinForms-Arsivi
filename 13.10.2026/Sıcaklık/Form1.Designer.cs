namespace Sıcaklık
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
            txtBoxDerece = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            lblSon = new Label();
            SuspendLayout();
            // 
            // txtBoxDerece
            // 
            txtBoxDerece.Location = new Point(97, 63);
            txtBoxDerece.Name = "txtBoxDerece";
            txtBoxDerece.Size = new Size(43, 23);
            txtBoxDerece.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 1;
            label1.Text = "Derece Giriniz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(137, 57);
            label2.Name = "label2";
            label2.Size = new Size(18, 23);
            label2.TabIndex = 2;
            label2.Text = "°";
            // 
            // button1
            // 
            button1.Location = new Point(65, 106);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Sorgula";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblSon
            // 
            lblSon.AutoSize = true;
            lblSon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSon.Location = new Point(64, 190);
            lblSon.Name = "lblSon";
            lblSon.Size = new Size(0, 19);
            lblSon.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(240, 262);
            Controls.Add(lblSon);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoxDerece);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxDerece;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label lblSon;
    }
}
