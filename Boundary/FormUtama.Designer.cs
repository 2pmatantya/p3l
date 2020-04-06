namespace Kouvee_Pet_Shop.Boundary
{
    partial class FormUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUtama));
            this.btnProduk = new System.Windows.Forms.Button();
            this.btnLayanan = new System.Windows.Forms.Button();
            this.btnKaryawan = new System.Windows.Forms.Button();
            this.btnHewan = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPesan = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProduk
            // 
            this.btnProduk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduk.Location = new System.Drawing.Point(16, 33);
            this.btnProduk.Name = "btnProduk";
            this.btnProduk.Size = new System.Drawing.Size(113, 48);
            this.btnProduk.TabIndex = 1;
            this.btnProduk.Text = "Data Produk";
            this.btnProduk.UseVisualStyleBackColor = true;
            this.btnProduk.Click += new System.EventHandler(this.button_produk);
            // 
            // btnLayanan
            // 
            this.btnLayanan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLayanan.Location = new System.Drawing.Point(150, 33);
            this.btnLayanan.Name = "btnLayanan";
            this.btnLayanan.Size = new System.Drawing.Size(113, 48);
            this.btnLayanan.TabIndex = 2;
            this.btnLayanan.Text = "Data Layanan";
            this.btnLayanan.UseVisualStyleBackColor = true;
            this.btnLayanan.Click += new System.EventHandler(this.btnLayanan_Click);
            // 
            // btnKaryawan
            // 
            this.btnKaryawan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaryawan.Location = new System.Drawing.Point(16, 28);
            this.btnKaryawan.Name = "btnKaryawan";
            this.btnKaryawan.Size = new System.Drawing.Size(113, 48);
            this.btnKaryawan.TabIndex = 3;
            this.btnKaryawan.Text = "Data Karyawan";
            this.btnKaryawan.UseVisualStyleBackColor = true;
            this.btnKaryawan.Click += new System.EventHandler(this.btnKaryawan_Click);
            // 
            // btnHewan
            // 
            this.btnHewan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHewan.Location = new System.Drawing.Point(150, 82);
            this.btnHewan.Name = "btnHewan";
            this.btnHewan.Size = new System.Drawing.Size(113, 48);
            this.btnHewan.TabIndex = 4;
            this.btnHewan.Text = "Data Hewan";
            this.btnHewan.UseVisualStyleBackColor = true;
            this.btnHewan.Click += new System.EventHandler(this.btnHewan_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(150, 28);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(113, 48);
            this.btnCustomer.TabIndex = 5;
            this.btnCustomer.Text = "Data Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.Location = new System.Drawing.Point(16, 82);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(113, 48);
            this.btnSupplier.TabIndex = 6;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProduk);
            this.groupBox1.Controls.Add(this.btnLayanan);
            this.groupBox1.Location = new System.Drawing.Point(12, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produk dan Layanan";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKaryawan);
            this.groupBox2.Controls.Add(this.btnCustomer);
            this.groupBox2.Controls.Add(this.btnHewan);
            this.groupBox2.Controls.Add(this.btnSupplier);
            this.groupBox2.Location = new System.Drawing.Point(12, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 151);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Location = new System.Drawing.Point(307, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 231);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pembayaran";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(196, 169);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(113, 38);
            this.button8.TabIndex = 0;
            this.button8.Text = "BAYAR";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPesan);
            this.groupBox4.Controls.Add(this.btnLaporan);
            this.groupBox4.Location = new System.Drawing.Point(12, 406);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(283, 105);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pemesanan dan Laporan";
            // 
            // btnPesan
            // 
            this.btnPesan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesan.Location = new System.Drawing.Point(16, 33);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(113, 48);
            this.btnPesan.TabIndex = 7;
            this.btnPesan.Text = "Pemesanan";
            this.btnPesan.UseVisualStyleBackColor = true;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaporan.Location = new System.Drawing.Point(150, 33);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(113, 48);
            this.btnLaporan.TabIndex = 8;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 125);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(307, 143);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(315, 131);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Status";
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(977, 519);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.IsMdiContainer = true;
            this.Name = "FormUtama";
            this.Text = "FormUtama";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnProduk;
        private System.Windows.Forms.Button btnLayanan;
        private System.Windows.Forms.Button btnKaryawan;
        private System.Windows.Forms.Button btnHewan;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnPesan;
    }
}