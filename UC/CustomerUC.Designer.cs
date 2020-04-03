namespace Kouvee_Pet_Shop.Control
{
    partial class CustomerUC
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
            this.txtTelp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamaKaryawan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.tgllahir = new System.Windows.Forms.DateTimePicker();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTelp
            // 
            this.txtTelp.Location = new System.Drawing.Point(178, 198);
            this.txtTelp.Name = "txtTelp";
            this.txtTelp.Size = new System.Drawing.Size(283, 20);
            this.txtTelp.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nomor Telp";
            // 
            // txtNamaKaryawan
            // 
            this.txtNamaKaryawan.Location = new System.Drawing.Point(178, 49);
            this.txtNamaKaryawan.Name = "txtNamaKaryawan";
            this.txtNamaKaryawan.Size = new System.Drawing.Size(483, 20);
            this.txtNamaKaryawan.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Alamat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nama Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tanggal Lahir";
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(415, 240);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(120, 43);
            this.btnBatal.TabIndex = 20;
            this.btnBatal.Text = "BATAL";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(541, 240);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(120, 43);
            this.btnSimpan.TabIndex = 19;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // tgllahir
            // 
            this.tgllahir.Location = new System.Drawing.Point(178, 156);
            this.tgllahir.Name = "tgllahir";
            this.tgllahir.Size = new System.Drawing.Size(200, 20);
            this.tgllahir.TabIndex = 21;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(178, 81);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(386, 54);
            this.txtAlamat.TabIndex = 22;
            // 
            // CustomerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.tgllahir);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtTelp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNamaKaryawan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerControl";
            this.Size = new System.Drawing.Size(676, 298);
            this.Load += new System.EventHandler(this.CustomerControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNamaKaryawan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.DateTimePicker tgllahir;
        private System.Windows.Forms.TextBox txtAlamat;
    }
}
