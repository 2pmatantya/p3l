namespace Kouvee_Pet_Shop.Control
{
    partial class ProdukPetControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.cmbJenis = new System.Windows.Forms.ComboBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(168, 41);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(567, 20);
            this.txtNama.TabIndex = 0;
            this.txtNama.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Produk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Harga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jumlah";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Jenis Produk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Supplier";
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(168, 80);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(236, 20);
            this.txtHarga.TabIndex = 6;
            // 
            // txtJumlah
            // 
            this.txtJumlah.Location = new System.Drawing.Point(168, 115);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(88, 20);
            this.txtJumlah.TabIndex = 7;
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(168, 183);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(236, 20);
            this.txtSupplier.TabIndex = 8;
            // 
            // cmbJenis
            // 
            this.cmbJenis.FormattingEnabled = true;
            this.cmbJenis.Location = new System.Drawing.Point(168, 148);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Size = new System.Drawing.Size(236, 21);
            this.cmbJenis.TabIndex = 9;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(615, 225);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(120, 43);
            this.btnSimpan.TabIndex = 10;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(489, 225);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(120, 43);
            this.btnBatal.TabIndex = 11;
            this.btnBatal.Text = "BATAL";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ProdukPetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.cmbJenis);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNama);
            this.Name = "ProdukPetControl";
            this.Size = new System.Drawing.Size(744, 281);
            this.Load += new System.EventHandler(this.ProdukPetControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
    }
}
