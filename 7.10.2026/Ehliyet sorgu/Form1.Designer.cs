namespace Ehliyet_sorgu
{
    partial class Ehliyet_Sorgu
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
            txtboxyas = new TextBox();
            btnsor = new Button();
            lblsonuc = new Label();
            lbl_motor = new Label();
            SuspendLayout();
            // 
            // txtboxyas
            // 
            txtboxyas.Location = new Point(49, 40);
            txtboxyas.Name = "txtboxyas";
            txtboxyas.Size = new Size(107, 23);
            txtboxyas.TabIndex = 0;
            // 
            // btnsor
            // 
            btnsor.ForeColor = Color.Black;
            btnsor.Location = new Point(61, 69);
            btnsor.Name = "btnsor";
            btnsor.Size = new Size(82, 33);
            btnsor.TabIndex = 1;
            btnsor.Text = "Başvur";
            btnsor.UseVisualStyleBackColor = true;
            btnsor.Click += btnsor_Click;
            // 
            // lblsonuc
            // 
            lblsonuc.AutoSize = true;
            lblsonuc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblsonuc.ForeColor = SystemColors.ButtonHighlight;
            lblsonuc.Location = new Point(40, 169);
            lblsonuc.Name = "lblsonuc";
            lblsonuc.Size = new Size(0, 19);
            lblsonuc.TabIndex = 2;
            // 
            // lbl_motor
            // 
            lbl_motor.AutoSize = true;
            lbl_motor.BackColor = Color.Teal;
            lbl_motor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_motor.ForeColor = Color.WhiteSmoke;
            lbl_motor.Location = new Point(40, 210);
            lbl_motor.Name = "lbl_motor";
            lbl_motor.Size = new Size(0, 19);
            lbl_motor.TabIndex = 3;
            // 
            // Ehliyet_Sorgu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(348, 250);
            Controls.Add(lbl_motor);
            Controls.Add(lblsonuc);
            Controls.Add(btnsor);
            Controls.Add(txtboxyas);
            ForeColor = Color.Transparent;
            Name = "Ehliyet_Sorgu";
            Text = "Ehliyet Sorgu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtboxyas;
        private Button btnsor;
        private Label lblsonuc;
        private Label lbl_motor;
    }
}
