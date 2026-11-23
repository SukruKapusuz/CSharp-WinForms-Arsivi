namespace Toplama_Çıkarma
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
            button1 = new Button();
            groupBox1 = new GroupBox();
            btnCarp = new RadioButton();
            btnBöl = new RadioButton();
            btnCıkar = new RadioButton();
            btnTopla = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            lblson = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(146, 261);
            button1.Name = "button1";
            button1.Size = new Size(122, 39);
            button1.TabIndex = 0;
            button1.Text = "İşlemi Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCarp);
            groupBox1.Controls.Add(btnBöl);
            groupBox1.Controls.Add(btnCıkar);
            groupBox1.Controls.Add(btnTopla);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(584, 90);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnCarp
            // 
            btnCarp.AutoSize = true;
            btnCarp.Location = new Point(444, 41);
            btnCarp.Name = "btnCarp";
            btnCarp.Size = new Size(55, 19);
            btnCarp.TabIndex = 3;
            btnCarp.TabStop = true;
            btnCarp.Text = "ÇARP";
            btnCarp.UseVisualStyleBackColor = true;
            // 
            // btnBöl
            // 
            btnBöl.AutoSize = true;
            btnBöl.Location = new Point(301, 41);
            btnBöl.Name = "btnBöl";
            btnBöl.Size = new Size(42, 19);
            btnBöl.TabIndex = 2;
            btnBöl.TabStop = true;
            btnBöl.Text = "Böl";
            btnBöl.UseVisualStyleBackColor = true;
            // 
            // btnCıkar
            // 
            btnCıkar.AutoSize = true;
            btnCıkar.Location = new Point(159, 41);
            btnCıkar.Name = "btnCıkar";
            btnCıkar.Size = new Size(52, 19);
            btnCıkar.TabIndex = 1;
            btnCıkar.TabStop = true;
            btnCıkar.Text = "Çıkar";
            btnCıkar.UseVisualStyleBackColor = true;
            // 
            // btnTopla
            // 
            btnTopla.AutoSize = true;
            btnTopla.Location = new Point(36, 41);
            btnTopla.Name = "btnTopla";
            btnTopla.Size = new Size(54, 19);
            btnTopla.TabIndex = 0;
            btnTopla.TabStop = true;
            btnTopla.Text = "Topla";
            btnTopla.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 136);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 3;
            label1.Text = "1.Sayıyı Giriniz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 180);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 4;
            label2.Text = "2.Sayıyı Giriniz:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(193, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(196, 177);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(129, 225);
            label3.Name = "label3";
            label3.Size = new Size(83, 28);
            label3.TabIndex = 4;
            label3.Text = "son hali:";
            // 
            // lblson
            // 
            lblson.AutoSize = true;
            lblson.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblson.Location = new Point(218, 230);
            lblson.Name = "lblson";
            lblson.Size = new Size(0, 23);
            lblson.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 450);
            Controls.Add(lblson);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private RadioButton btnCarp;
        private RadioButton btnBöl;
        private RadioButton btnCıkar;
        private RadioButton btnTopla;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label lblson;
    }
}
