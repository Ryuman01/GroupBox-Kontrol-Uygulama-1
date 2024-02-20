namespace GroupBox_Kontrolü_Uygulama_1
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
            this.gbIslemci = new System.Windows.Forms.GroupBox();
            this.gbRam = new System.Windows.Forms.GroupBox();
            this.gbSsd = new System.Windows.Forms.GroupBox();
            this.gbEkdo = new System.Windows.Forms.GroupBox();
            this.rbCpuI7 = new System.Windows.Forms.RadioButton();
            this.rbCpuI5 = new System.Windows.Forms.RadioButton();
            this.rbCpuI3 = new System.Windows.Forms.RadioButton();
            this.rbCpuR5 = new System.Windows.Forms.RadioButton();
            this.rbCpuR3 = new System.Windows.Forms.RadioButton();
            this.rbRam16 = new System.Windows.Forms.RadioButton();
            this.rbRam8 = new System.Windows.Forms.RadioButton();
            this.rbRam4 = new System.Windows.Forms.RadioButton();
            this.rbHdd1000 = new System.Windows.Forms.RadioButton();
            this.rbHdd500 = new System.Windows.Forms.RadioButton();
            this.rbHdd320 = new System.Windows.Forms.RadioButton();
            this.CbDVD = new System.Windows.Forms.CheckBox();
            this.CbWebcam = new System.Windows.Forms.CheckBox();
            this.CbWifi = new System.Windows.Forms.CheckBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.gbIslemci.SuspendLayout();
            this.gbRam.SuspendLayout();
            this.gbSsd.SuspendLayout();
            this.gbEkdo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIslemci
            // 
            this.gbIslemci.Controls.Add(this.rbCpuR3);
            this.gbIslemci.Controls.Add(this.rbCpuR5);
            this.gbIslemci.Controls.Add(this.rbCpuI3);
            this.gbIslemci.Controls.Add(this.rbCpuI5);
            this.gbIslemci.Controls.Add(this.rbCpuI7);
            this.gbIslemci.Location = new System.Drawing.Point(32, 26);
            this.gbIslemci.Name = "gbIslemci";
            this.gbIslemci.Size = new System.Drawing.Size(164, 151);
            this.gbIslemci.TabIndex = 0;
            this.gbIslemci.TabStop = false;
            this.gbIslemci.Text = "İşlemciler";
            // 
            // gbRam
            // 
            this.gbRam.Controls.Add(this.rbRam4);
            this.gbRam.Controls.Add(this.rbRam8);
            this.gbRam.Controls.Add(this.rbRam16);
            this.gbRam.Location = new System.Drawing.Point(232, 26);
            this.gbRam.Name = "gbRam";
            this.gbRam.Size = new System.Drawing.Size(171, 105);
            this.gbRam.TabIndex = 0;
            this.gbRam.TabStop = false;
            this.gbRam.Text = "Ram Bellek";
            // 
            // gbSsd
            // 
            this.gbSsd.Controls.Add(this.rbHdd320);
            this.gbSsd.Controls.Add(this.rbHdd500);
            this.gbSsd.Controls.Add(this.rbHdd1000);
            this.gbSsd.Location = new System.Drawing.Point(232, 186);
            this.gbSsd.Name = "gbSsd";
            this.gbSsd.Size = new System.Drawing.Size(180, 116);
            this.gbSsd.TabIndex = 0;
            this.gbSsd.TabStop = false;
            this.gbSsd.Text = "Sabit Disk";
            // 
            // gbEkdo
            // 
            this.gbEkdo.Controls.Add(this.CbWifi);
            this.gbEkdo.Controls.Add(this.CbWebcam);
            this.gbEkdo.Controls.Add(this.CbDVD);
            this.gbEkdo.Location = new System.Drawing.Point(32, 186);
            this.gbEkdo.Name = "gbEkdo";
            this.gbEkdo.Size = new System.Drawing.Size(127, 116);
            this.gbEkdo.TabIndex = 0;
            this.gbEkdo.TabStop = false;
            this.gbEkdo.Text = "Ek Donanımlar";
            // 
            // rbCpuI7
            // 
            this.rbCpuI7.AutoSize = true;
            this.rbCpuI7.Location = new System.Drawing.Point(7, 19);
            this.rbCpuI7.Name = "rbCpuI7";
            this.rbCpuI7.Size = new System.Drawing.Size(81, 17);
            this.rbCpuI7.TabIndex = 0;
            this.rbCpuI7.TabStop = true;
            this.rbCpuI7.Text = "Intel Core i7";
            this.rbCpuI7.UseVisualStyleBackColor = true;
            // 
            // rbCpuI5
            // 
            this.rbCpuI5.AutoSize = true;
            this.rbCpuI5.Location = new System.Drawing.Point(7, 42);
            this.rbCpuI5.Name = "rbCpuI5";
            this.rbCpuI5.Size = new System.Drawing.Size(81, 17);
            this.rbCpuI5.TabIndex = 1;
            this.rbCpuI5.TabStop = true;
            this.rbCpuI5.Text = "Intel Core i5";
            this.rbCpuI5.UseVisualStyleBackColor = true;
            // 
            // rbCpuI3
            // 
            this.rbCpuI3.AutoSize = true;
            this.rbCpuI3.Location = new System.Drawing.Point(7, 65);
            this.rbCpuI3.Name = "rbCpuI3";
            this.rbCpuI3.Size = new System.Drawing.Size(81, 17);
            this.rbCpuI3.TabIndex = 2;
            this.rbCpuI3.TabStop = true;
            this.rbCpuI3.Text = "Intel Core i3";
            this.rbCpuI3.UseVisualStyleBackColor = true;
            // 
            // rbCpuR5
            // 
            this.rbCpuR5.AutoSize = true;
            this.rbCpuR5.Location = new System.Drawing.Point(7, 88);
            this.rbCpuR5.Name = "rbCpuR5";
            this.rbCpuR5.Size = new System.Drawing.Size(91, 17);
            this.rbCpuR5.TabIndex = 3;
            this.rbCpuR5.TabStop = true;
            this.rbCpuR5.Text = "AMD Ryzen 5";
            this.rbCpuR5.UseVisualStyleBackColor = true;
            // 
            // rbCpuR3
            // 
            this.rbCpuR3.AutoSize = true;
            this.rbCpuR3.Location = new System.Drawing.Point(7, 111);
            this.rbCpuR3.Name = "rbCpuR3";
            this.rbCpuR3.Size = new System.Drawing.Size(91, 17);
            this.rbCpuR3.TabIndex = 4;
            this.rbCpuR3.TabStop = true;
            this.rbCpuR3.Text = "AMD Ryzen 3";
            this.rbCpuR3.UseVisualStyleBackColor = true;
            // 
            // rbRam16
            // 
            this.rbRam16.AutoSize = true;
            this.rbRam16.Location = new System.Drawing.Point(21, 28);
            this.rbRam16.Name = "rbRam16";
            this.rbRam16.Size = new System.Drawing.Size(55, 17);
            this.rbRam16.TabIndex = 0;
            this.rbRam16.TabStop = true;
            this.rbRam16.Text = "16 GB";
            this.rbRam16.UseVisualStyleBackColor = true;
            // 
            // rbRam8
            // 
            this.rbRam8.AutoSize = true;
            this.rbRam8.Location = new System.Drawing.Point(21, 51);
            this.rbRam8.Name = "rbRam8";
            this.rbRam8.Size = new System.Drawing.Size(49, 17);
            this.rbRam8.TabIndex = 1;
            this.rbRam8.TabStop = true;
            this.rbRam8.Text = "8 GB";
            this.rbRam8.UseVisualStyleBackColor = true;
            // 
            // rbRam4
            // 
            this.rbRam4.AutoSize = true;
            this.rbRam4.Location = new System.Drawing.Point(21, 74);
            this.rbRam4.Name = "rbRam4";
            this.rbRam4.Size = new System.Drawing.Size(49, 17);
            this.rbRam4.TabIndex = 2;
            this.rbRam4.TabStop = true;
            this.rbRam4.Text = "4 GB";
            this.rbRam4.UseVisualStyleBackColor = true;
            // 
            // rbHdd1000
            // 
            this.rbHdd1000.AutoSize = true;
            this.rbHdd1000.Location = new System.Drawing.Point(23, 28);
            this.rbHdd1000.Name = "rbHdd1000";
            this.rbHdd1000.Size = new System.Drawing.Size(48, 17);
            this.rbHdd1000.TabIndex = 0;
            this.rbHdd1000.TabStop = true;
            this.rbHdd1000.Text = "1 TB";
            this.rbHdd1000.UseVisualStyleBackColor = true;
            // 
            // rbHdd500
            // 
            this.rbHdd500.AutoSize = true;
            this.rbHdd500.Location = new System.Drawing.Point(23, 51);
            this.rbHdd500.Name = "rbHdd500";
            this.rbHdd500.Size = new System.Drawing.Size(61, 17);
            this.rbHdd500.TabIndex = 1;
            this.rbHdd500.TabStop = true;
            this.rbHdd500.Text = "500 GB";
            this.rbHdd500.UseVisualStyleBackColor = true;
            // 
            // rbHdd320
            // 
            this.rbHdd320.AutoSize = true;
            this.rbHdd320.Location = new System.Drawing.Point(23, 74);
            this.rbHdd320.Name = "rbHdd320";
            this.rbHdd320.Size = new System.Drawing.Size(61, 17);
            this.rbHdd320.TabIndex = 2;
            this.rbHdd320.TabStop = true;
            this.rbHdd320.Text = "320 GB";
            this.rbHdd320.UseVisualStyleBackColor = true;
            // 
            // CbDVD
            // 
            this.CbDVD.AutoSize = true;
            this.CbDVD.Location = new System.Drawing.Point(18, 38);
            this.CbDVD.Name = "CbDVD";
            this.CbDVD.Size = new System.Drawing.Size(71, 17);
            this.CbDVD.TabIndex = 0;
            this.CbDVD.Text = "DVD RW";
            this.CbDVD.UseVisualStyleBackColor = true;
            // 
            // CbWebcam
            // 
            this.CbWebcam.AutoSize = true;
            this.CbWebcam.Location = new System.Drawing.Point(18, 61);
            this.CbWebcam.Name = "CbWebcam";
            this.CbWebcam.Size = new System.Drawing.Size(69, 17);
            this.CbWebcam.TabIndex = 1;
            this.CbWebcam.Text = "Webcam";
            this.CbWebcam.UseVisualStyleBackColor = true;
            // 
            // CbWifi
            // 
            this.CbWifi.AutoSize = true;
            this.CbWifi.Location = new System.Drawing.Point(18, 84);
            this.CbWifi.Name = "CbWifi";
            this.CbWifi.Size = new System.Drawing.Size(88, 17);
            this.CbWifi.TabIndex = 2;
            this.CbWifi.Text = "Wireless Cart";
            this.CbWifi.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHesapla.Location = new System.Drawing.Point(228, 140);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(175, 40);
            this.btnHesapla.TabIndex = 1;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.gbRam);
            this.Controls.Add(this.gbSsd);
            this.Controls.Add(this.gbEkdo);
            this.Controls.Add(this.gbIslemci);
            this.Name = "Form1";
            this.Text = "GroupBox Kontrolü Uygulama 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbIslemci.ResumeLayout(false);
            this.gbIslemci.PerformLayout();
            this.gbRam.ResumeLayout(false);
            this.gbRam.PerformLayout();
            this.gbSsd.ResumeLayout(false);
            this.gbSsd.PerformLayout();
            this.gbEkdo.ResumeLayout(false);
            this.gbEkdo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIslemci;
        private System.Windows.Forms.GroupBox gbRam;
        private System.Windows.Forms.GroupBox gbSsd;
        private System.Windows.Forms.GroupBox gbEkdo;
        private System.Windows.Forms.RadioButton rbCpuR3;
        private System.Windows.Forms.RadioButton rbCpuR5;
        private System.Windows.Forms.RadioButton rbCpuI3;
        private System.Windows.Forms.RadioButton rbCpuI5;
        private System.Windows.Forms.RadioButton rbCpuI7;
        private System.Windows.Forms.RadioButton rbRam4;
        private System.Windows.Forms.RadioButton rbRam8;
        private System.Windows.Forms.RadioButton rbRam16;
        private System.Windows.Forms.RadioButton rbHdd320;
        private System.Windows.Forms.RadioButton rbHdd500;
        private System.Windows.Forms.RadioButton rbHdd1000;
        private System.Windows.Forms.CheckBox CbWifi;
        private System.Windows.Forms.CheckBox CbWebcam;
        private System.Windows.Forms.CheckBox CbDVD;
        private System.Windows.Forms.Button btnHesapla;
    }
}

