namespace AlfabedeKac
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn = new System.Windows.Forms.Button();
            this.Boxharf = new System.Windows.Forms.ComboBox();
            this.lblson = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(67, 128);
            this.btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(88, 23);
            this.btn.TabIndex = 0;
            this.btn.Text = "Sorgula";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Boxharf
            // 
            this.Boxharf.FormattingEnabled = true;
            this.Boxharf.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "Ç",
            "D",
            "E",
            "F",
            "G",
            "Ğ",
            "H",
            "I",
            "İ",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "Ö",
            "P",
            "R",
            "S",
            "Ş",
            "T",
            "U",
            "Ü",
            "V",
            "Y",
            "Z"});
            this.Boxharf.Location = new System.Drawing.Point(81, 29);
            this.Boxharf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boxharf.Name = "Boxharf";
            this.Boxharf.Size = new System.Drawing.Size(140, 21);
            this.Boxharf.TabIndex = 1;
            // 
            // lblson
            // 
            this.lblson.AutoSize = true;
            this.lblson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblson.Location = new System.Drawing.Point(64, 74);
            this.lblson.Name = "lblson";
            this.lblson.Size = new System.Drawing.Size(0, 13);
            this.lblson.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 217);
            this.Controls.Add(this.lblson);
            this.Controls.Add(this.Boxharf);
            this.Controls.Add(this.btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Alfabenin kaçıncı harfi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ComboBox Boxharf;
        private System.Windows.Forms.Label lblson;
    }
}

