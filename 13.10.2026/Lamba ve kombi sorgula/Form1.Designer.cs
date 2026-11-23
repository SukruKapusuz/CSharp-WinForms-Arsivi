namespace Lamba_ve_kombi_sorgula
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
            btnrapor = new Button();
            groupBox1 = new GroupBox();
            checkboxİsik = new CheckBox();
            checkboxKombi = new CheckBox();
            groupBox2 = new GroupBox();
            lstBoxRapor = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnrapor
            // 
            btnrapor.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnrapor.Location = new Point(62, 177);
            btnrapor.Name = "btnrapor";
            btnrapor.Size = new Size(80, 32);
            btnrapor.TabIndex = 0;
            btnrapor.Text = "Sor";
            btnrapor.UseVisualStyleBackColor = true;
            btnrapor.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkboxİsik);
            groupBox1.Controls.Add(checkboxKombi);
            groupBox1.Controls.Add(btnrapor);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(280, 266);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bilgi";
            // 
            // checkboxİsik
            // 
            checkboxİsik.AutoSize = true;
            checkboxİsik.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            checkboxİsik.Location = new Point(33, 91);
            checkboxİsik.Name = "checkboxİsik";
            checkboxİsik.Size = new Size(80, 41);
            checkboxİsik.TabIndex = 2;
            checkboxİsik.Text = "Işık";
            checkboxİsik.UseVisualStyleBackColor = true;
            // 
            // checkboxKombi
            // 
            checkboxKombi.AutoSize = true;
            checkboxKombi.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            checkboxKombi.Location = new Point(35, 53);
            checkboxKombi.Name = "checkboxKombi";
            checkboxKombi.Size = new Size(121, 41);
            checkboxKombi.TabIndex = 1;
            checkboxKombi.Text = "Kombi";
            checkboxKombi.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstBoxRapor);
            groupBox2.Location = new Point(314, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(266, 266);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "İşlem";
            // 
            // lstBoxRapor
            // 
            lstBoxRapor.FormattingEnabled = true;
            lstBoxRapor.ItemHeight = 15;
            lstBoxRapor.Location = new Point(27, 28);
            lstBoxRapor.Name = "lstBoxRapor";
            lstBoxRapor.Size = new Size(216, 214);
            lstBoxRapor.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 290);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnrapor;
        private GroupBox groupBox1;
        private CheckBox checkboxİsik;
        private CheckBox checkboxKombi;
        private GroupBox groupBox2;
        private ListBox lstBoxRapor;
    }
}
