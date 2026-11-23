namespace hafta_içi_hafta_sonu
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
            this.lblsonuc = new System.Windows.Forms.Label();
            this.btnsorgula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsonuc.Location = new System.Drawing.Point(53, 57);
            this.lblsonuc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(0, 19);
            this.lblsonuc.TabIndex = 0;
            // 
            // btnsorgula
            // 
            this.btnsorgula.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsorgula.Location = new System.Drawing.Point(75, 145);
            this.btnsorgula.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnsorgula.Name = "btnsorgula";
            this.btnsorgula.Size = new System.Drawing.Size(165, 79);
            this.btnsorgula.TabIndex = 1;
            this.btnsorgula.Text = "Sorgula";
            this.btnsorgula.UseVisualStyleBackColor = true;
            this.btnsorgula.Click += new System.EventHandler(this.btnsorgula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 239);
            this.Controls.Add(this.btnsorgula);
            this.Controls.Add(this.lblsonuc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Hafta sonu sorgulama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.Button btnsorgula;
    }
}

