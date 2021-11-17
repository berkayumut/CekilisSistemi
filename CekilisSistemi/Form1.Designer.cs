namespace CekilisSistemi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listKatilimci = new System.Windows.Forms.ListBox();
            this.txtKatilimci = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtKazananSayi = new System.Windows.Forms.TextBox();
            this.txtYedekSayi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listKazanan = new System.Windows.Forms.ListBox();
            this.listYedek = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCekilisYap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.txtKatilimci);
            this.panel1.Controls.Add(this.listKatilimci);
            this.panel1.Location = new System.Drawing.Point(4, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 254);
            this.panel1.TabIndex = 0;
            // 
            // listKatilimci
            // 
            this.listKatilimci.FormattingEnabled = true;
            this.listKatilimci.Location = new System.Drawing.Point(3, 3);
            this.listKatilimci.Name = "listKatilimci";
            this.listKatilimci.Size = new System.Drawing.Size(141, 199);
            this.listKatilimci.TabIndex = 0;
            // 
            // txtKatilimci
            // 
            this.txtKatilimci.Location = new System.Drawing.Point(155, 3);
            this.txtKatilimci.Multiline = true;
            this.txtKatilimci.Name = "txtKatilimci";
            this.txtKatilimci.Size = new System.Drawing.Size(147, 34);
            this.txtKatilimci.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEkle.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(155, 43);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(98, 36);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCekilisYap);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.listYedek);
            this.panel2.Controls.Add(this.listKazanan);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtYedekSayi);
            this.panel2.Controls.Add(this.txtKazananSayi);
            this.panel2.Location = new System.Drawing.Point(330, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 255);
            this.panel2.TabIndex = 1;
            // 
            // txtKazananSayi
            // 
            this.txtKazananSayi.Location = new System.Drawing.Point(103, 13);
            this.txtKazananSayi.Name = "txtKazananSayi";
            this.txtKazananSayi.Size = new System.Drawing.Size(100, 20);
            this.txtKazananSayi.TabIndex = 0;
            // 
            // txtYedekSayi
            // 
            this.txtYedekSayi.Location = new System.Drawing.Point(103, 36);
            this.txtYedekSayi.Name = "txtYedekSayi";
            this.txtYedekSayi.Size = new System.Drawing.Size(100, 20);
            this.txtYedekSayi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kazanan Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yedek Sayısı:";
            // 
            // listKazanan
            // 
            this.listKazanan.FormattingEnabled = true;
            this.listKazanan.Location = new System.Drawing.Point(29, 127);
            this.listKazanan.Name = "listKazanan";
            this.listKazanan.Size = new System.Drawing.Size(128, 121);
            this.listKazanan.TabIndex = 3;
            // 
            // listYedek
            // 
            this.listYedek.FormattingEnabled = true;
            this.listYedek.Location = new System.Drawing.Point(181, 127);
            this.listYedek.Name = "listYedek";
            this.listYedek.Size = new System.Drawing.Size(128, 121);
            this.listYedek.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "KAZANANLAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "YEDEKLER";
            // 
            // btnCekilisYap
            // 
            this.btnCekilisYap.BackColor = System.Drawing.Color.Lime;
            this.btnCekilisYap.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCekilisYap.Location = new System.Drawing.Point(213, 16);
            this.btnCekilisYap.Name = "btnCekilisYap";
            this.btnCekilisYap.Size = new System.Drawing.Size(96, 34);
            this.btnCekilisYap.TabIndex = 7;
            this.btnCekilisYap.Text = "Çekiliş Yap";
            this.btnCekilisYap.UseVisualStyleBackColor = false;
            this.btnCekilisYap.Click += new System.EventHandler(this.btnCekilisYap_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(155, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 300);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtKatilimci;
        private System.Windows.Forms.ListBox listKatilimci;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCekilisYap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listYedek;
        private System.Windows.Forms.ListBox listKazanan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYedekSayi;
        private System.Windows.Forms.TextBox txtKazananSayi;
        private System.Windows.Forms.Button button1;
    }
}

