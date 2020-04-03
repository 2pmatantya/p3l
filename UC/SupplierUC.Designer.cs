namespace Kouvee_Pet_Shop.UC
{
    partial class SupplierUC
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
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtNamaSupplier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtTelp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(176, 57);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(386, 54);
            this.txtAlamat.TabIndex = 26;
            this.txtAlamat.TextChanged += new System.EventHandler(this.txtAlamat_TextChanged);
            // 
            // txtNamaSupplier
            // 
            this.txtNamaSupplier.Location = new System.Drawing.Point(176, 25);
            this.txtNamaSupplier.Name = "txtNamaSupplier";
            this.txtNamaSupplier.Size = new System.Drawing.Size(483, 20);
            this.txtNamaSupplier.TabIndex = 25;
            this.txtNamaSupplier.TextChanged += new System.EventHandler(this.txtNamaSupplier_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Alamat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nama Supplier";
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(413, 169);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(120, 43);
            this.btnBatal.TabIndex = 30;
            this.btnBatal.Text = "BATAL";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(539, 169);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(120, 43);
            this.btnSimpan.TabIndex = 29;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtTelp
            // 
            this.txtTelp.Location = new System.Drawing.Point(176, 127);
            this.txtTelp.Name = "txtTelp";
            this.txtTelp.Size = new System.Drawing.Size(283, 20);
            this.txtTelp.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nomor Telp";
            // 
            // SupplierUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtTelp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNamaSupplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "SupplierUC";
            this.Size = new System.Drawing.Size(677, 224);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtNamaSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtTelp;
        private System.Windows.Forms.Label label4;
    }
}
