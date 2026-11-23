namespace Not_Sistemi
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
            label1 = new Label();
            lblson = new Label();
            txtBoxNot = new TextBox();
            btnSon = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(294, 20);
            label1.TabIndex = 0;
            label1.Text = "Notunuzun derecelendirilmesi için giriniz";
            // 
            // lblson
            // 
            lblson.AutoSize = true;
            lblson.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblson.Location = new Point(32, 143);
            lblson.Name = "lblson";
            lblson.Size = new Size(0, 23);
            lblson.TabIndex = 3;
            // 
            // txtBoxNot
            // 
            txtBoxNot.Location = new Point(106, 52);
            txtBoxNot.Name = "txtBoxNot";
            txtBoxNot.Size = new Size(100, 23);
            txtBoxNot.TabIndex = 4;
            // 
            // btnSon
            // 
            btnSon.Location = new Point(106, 81);
            btnSon.Name = "btnSon";
            btnSon.Size = new Size(100, 23);
            btnSon.TabIndex = 5;
            btnSon.Text = "Değerlendir";
            btnSon.UseVisualStyleBackColor = true;
            btnSon.Click += btnSon_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(332, 230);
            Controls.Add(btnSon);
            Controls.Add(txtBoxNot);
            Controls.Add(lblson);
            Controls.Add(label1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblson;
        private TextBox txtBoxNot;
        private Button btnSon;
    }
}
