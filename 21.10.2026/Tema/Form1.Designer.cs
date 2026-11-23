namespace Tema
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
            rdbtnkara = new RadioButton();
            rdybtnacık = new RadioButton();
            btnUygula = new Button();
            SuspendLayout();
            // 
            // rdbtnkara
            // 
            rdbtnkara.AutoSize = true;
            rdbtnkara.Location = new Point(66, 55);
            rdbtnkara.Name = "rdbtnkara";
            rdbtnkara.Size = new Size(83, 19);
            rdbtnkara.TabIndex = 0;
            rdbtnkara.TabStop = true;
            rdbtnkara.Text = "Siyah tema";
            rdbtnkara.UseVisualStyleBackColor = true;
            // 
            // rdybtnacık
            // 
            rdybtnacık.AutoSize = true;
            rdybtnacık.Location = new Point(66, 112);
            rdybtnacık.Name = "rdybtnacık";
            rdybtnacık.Size = new Size(76, 19);
            rdybtnacık.TabIndex = 1;
            rdybtnacık.TabStop = true;
            rdybtnacık.Text = "açık tema";
            rdybtnacık.UseVisualStyleBackColor = true;
            // 
            // btnUygula
            // 
            btnUygula.Location = new Point(66, 183);
            btnUygula.Name = "btnUygula";
            btnUygula.Size = new Size(75, 23);
            btnUygula.TabIndex = 2;
            btnUygula.Text = "Uygula";
            btnUygula.UseVisualStyleBackColor = true;
            btnUygula.Click += btnUygula_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 261);
            Controls.Add(btnUygula);
            Controls.Add(rdybtnacık);
            Controls.Add(rdbtnkara);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdbtnkara;
        private RadioButton rdybtnacık;
        private Button btnUygula;
    }
}
