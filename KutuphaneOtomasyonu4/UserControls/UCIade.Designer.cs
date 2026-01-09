namespace KutuphaneOtomasyonu4.UserControls
{
    partial class UCIade
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCIade));
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi2 = new System.Windows.Forms.TextBox();
            this.txtKitapAdi2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIade = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(72, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULLANICI ADI:";
            // 
            // txtKullaniciAdi2
            // 
            this.txtKullaniciAdi2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi2.Location = new System.Drawing.Point(275, 197);
            this.txtKullaniciAdi2.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciAdi2.Name = "txtKullaniciAdi2";
            this.txtKullaniciAdi2.Size = new System.Drawing.Size(202, 42);
            this.txtKullaniciAdi2.TabIndex = 1;
            // 
            // txtKitapAdi2
            // 
            this.txtKitapAdi2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAdi2.Location = new System.Drawing.Point(275, 257);
            this.txtKitapAdi2.Margin = new System.Windows.Forms.Padding(4);
            this.txtKitapAdi2.Name = "txtKitapAdi2";
            this.txtKitapAdi2.Size = new System.Drawing.Size(202, 42);
            this.txtKitapAdi2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(128, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "KİTAP ADI:";
            // 
            // btnIade
            // 
            this.btnIade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnIade.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIade.ForeColor = System.Drawing.Color.Maroon;
            this.btnIade.Location = new System.Drawing.Point(199, 321);
            this.btnIade.Margin = new System.Windows.Forms.Padding(4);
            this.btnIade.Name = "btnIade";
            this.btnIade.Size = new System.Drawing.Size(157, 42);
            this.btnIade.TabIndex = 4;
            this.btnIade.Text = "İADE ET";
            this.btnIade.UseVisualStyleBackColor = false;
            this.btnIade.Click += new System.EventHandler(this.btnIade_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(176, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // UCIade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKitapAdi2);
            this.Controls.Add(this.txtKullaniciAdi2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCIade";
            this.Size = new System.Drawing.Size(595, 467);
            this.Load += new System.EventHandler(this.UCIade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullaniciAdi2;
        private System.Windows.Forms.TextBox txtKitapAdi2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIade;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
