namespace müşteri_aratmak
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
            btnAra = new Button();
            lstMusteri = new ListBox();
            txtAra = new TextBox();
            SuspendLayout();
            // 
            // btnAra
            // 
            btnAra.Location = new Point(231, 379);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(75, 23);
            btnAra.TabIndex = 0;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // lstMusteri
            // 
            lstMusteri.BackColor = SystemColors.Window;
            lstMusteri.FormattingEnabled = true;
            lstMusteri.ItemHeight = 15;
            lstMusteri.Items.AddRange(new object[] { "Hakkı", "Samet", "Şükrü", "Mehmet" });
            lstMusteri.Location = new Point(12, 12);
            lstMusteri.Name = "lstMusteri";
            lstMusteri.Size = new Size(382, 304);
            lstMusteri.TabIndex = 1;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(52, 379);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(113, 23);
            txtAra.TabIndex = 3;
            txtAra.Text = " ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(406, 450);
            Controls.Add(txtAra);
            Controls.Add(lstMusteri);
            Controls.Add(btnAra);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAra;
        private ListBox lstMusteri;
        private TextBox txtAra;
    }
}
