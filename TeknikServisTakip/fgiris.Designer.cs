namespace TeknikServisTakip
{
    partial class fgiris
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckuladi = new System.Windows.Forms.ComboBox();
            this.tsifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bgiris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TeknikServisTakip.Properties.Resources.setting__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(417, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teknik Servis Takip Programı\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(417, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı Adı : ";
            // 
            // ckuladi
            // 
            this.ckuladi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ckuladi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ckuladi.FormattingEnabled = true;
            this.ckuladi.Location = new System.Drawing.Point(559, 113);
            this.ckuladi.Name = "ckuladi";
            this.ckuladi.Size = new System.Drawing.Size(236, 33);
            this.ckuladi.TabIndex = 2;
            // 
            // tsifre
            // 
            this.tsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tsifre.Location = new System.Drawing.Point(559, 157);
            this.tsifre.Name = "tsifre";
            this.tsifre.PasswordChar = '*';
            this.tsifre.Size = new System.Drawing.Size(236, 30);
            this.tsifre.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(484, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre : ";
            // 
            // bgiris
            // 
            this.bgiris.Location = new System.Drawing.Point(422, 193);
            this.bgiris.Name = "bgiris";
            this.bgiris.Size = new System.Drawing.Size(373, 62);
            this.bgiris.TabIndex = 1;
            this.bgiris.Text = "Giriş Yap";
            this.bgiris.UseVisualStyleBackColor = true;
            this.bgiris.Click += new System.EventHandler(this.bgiris_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.bgiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 327);
            this.Controls.Add(this.bgiris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tsifre);
            this.Controls.Add(this.ckuladi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teknik Servis Takip Programı ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ckuladi;
        private System.Windows.Forms.TextBox tsifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bgiris;
    }
}

