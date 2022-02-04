namespace TeknikServisTakip
{
    partial class Fsifredegistir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tkullaniciadi = new System.Windows.Forms.TextBox();
            this.teskisifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tyenisifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // tkullaniciadi
            // 
            this.tkullaniciadi.Location = new System.Drawing.Point(56, 68);
            this.tkullaniciadi.Name = "tkullaniciadi";
            this.tkullaniciadi.Size = new System.Drawing.Size(302, 26);
            this.tkullaniciadi.TabIndex = 1;
            this.tkullaniciadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // teskisifre
            // 
            this.teskisifre.Location = new System.Drawing.Point(56, 120);
            this.teskisifre.Name = "teskisifre";
            this.teskisifre.PasswordChar = '*';
            this.teskisifre.Size = new System.Drawing.Size(138, 26);
            this.teskisifre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanılan Şifre";
            // 
            // tyenisifre
            // 
            this.tyenisifre.Location = new System.Drawing.Point(220, 120);
            this.tyenisifre.Name = "tyenisifre";
            this.tyenisifre.PasswordChar = '*';
            this.tyenisifre.Size = new System.Drawing.Size(138, 26);
            this.tyenisifre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yeni Şifre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 101);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fsifredegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 195);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tyenisifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teskisifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tkullaniciadi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Fsifredegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanici Sifre Degistir";
            this.Load += new System.EventHandler(this.Fsifredegistir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tkullaniciadi;
        private System.Windows.Forms.TextBox teskisifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tyenisifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}