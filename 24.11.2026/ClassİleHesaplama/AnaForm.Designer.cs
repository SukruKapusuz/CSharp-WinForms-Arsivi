namespace ClassİleHesaplama
{
    partial class AnaForm
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
            button2 = new Button();
            btnKare = new Button();
            button4 = new Button();
            btnDikdortgen = new Button();
            button6 = new Button();
            button7 = new Button();
            btnUcgen = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.Location = new Point(168, 275);
            button1.Name = "button1";
            button1.Size = new Size(128, 86);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button2.Location = new Point(168, 183);
            button2.Name = "button2";
            button2.Size = new Size(128, 86);
            button2.TabIndex = 0;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnKare
            // 
            btnKare.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnKare.Location = new Point(436, 91);
            btnKare.Name = "btnKare";
            btnKare.Size = new Size(128, 86);
            btnKare.TabIndex = 0;
            btnKare.Text = "Kare";
            btnKare.UseVisualStyleBackColor = true;
            btnKare.Click += btnKare_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button4.Location = new Point(302, 183);
            button4.Name = "button4";
            button4.Size = new Size(128, 86);
            button4.TabIndex = 0;
            button4.Text = "button1";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnDikdortgen
            // 
            btnDikdortgen.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnDikdortgen.Location = new Point(168, 91);
            btnDikdortgen.Name = "btnDikdortgen";
            btnDikdortgen.Size = new Size(128, 86);
            btnDikdortgen.TabIndex = 0;
            btnDikdortgen.Text = "Dikdörtgen";
            btnDikdortgen.UseVisualStyleBackColor = true;
            btnDikdortgen.Click += btnDikdortgen_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button6.Location = new Point(302, 275);
            button6.Name = "button6";
            button6.Size = new Size(128, 86);
            button6.TabIndex = 0;
            button6.Text = "button1";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button7.Location = new Point(436, 275);
            button7.Name = "button7";
            button7.Size = new Size(128, 86);
            button7.TabIndex = 0;
            button7.Text = "button1";
            button7.UseVisualStyleBackColor = true;
            // 
            // btnUcgen
            // 
            btnUcgen.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnUcgen.Location = new Point(302, 91);
            btnUcgen.Name = "btnUcgen";
            btnUcgen.Size = new Size(128, 86);
            btnUcgen.TabIndex = 0;
            btnUcgen.Text = "Üçgen";
            btnUcgen.UseVisualStyleBackColor = true;
            btnUcgen.Click += btnUcgen_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button9.Location = new Point(436, 183);
            button9.Name = "button9";
            button9.Size = new Size(128, 86);
            button9.TabIndex = 0;
            button9.Text = "button1";
            button9.UseVisualStyleBackColor = true;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.YellowGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(button9);
            Controls.Add(btnDikdortgen);
            Controls.Add(btnUcgen);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button7);
            Controls.Add(btnKare);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AnaForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btnKare;
        private Button button4;
        private Button btnDikdortgen;
        private Button button6;
        private Button button7;
        private Button btnUcgen;
        private Button button9;
    }
}
