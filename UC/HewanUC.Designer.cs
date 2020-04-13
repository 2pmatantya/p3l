namespace Kouvee_Pet_Shop.Control
{
    partial class HewanUC
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtHewan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbJenisHewan = new System.Windows.Forms.ComboBox();
            this.cmbUkuran = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Jenis Hewan";
//            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(178, 61);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(483, 20);
            this.txtNama.TabIndex = 24;
            // 
            // txtHewan
            // 
            this.txtHewan.Location = new System.Drawing.Point(178, 29);
            this.txtHewan.Name = "txtHewan";
            this.txtHewan.Size = new System.Drawing.Size(483, 20);
            this.txtHewan.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nama Hewan";
            // 
            // cmbJenisHewan
            // 
            this.cmbJenisHewan.FormattingEnabled = true;
            this.cmbJenisHewan.Location = new System.Drawing.Point(178, 97);
            this.cmbJenisHewan.Name = "cmbJenisHewan";
            this.cmbJenisHewan.Size = new System.Drawing.Size(183, 21);
            this.cmbJenisHewan.TabIndex = 29;
            // 
            // cmbUkuran
            // 
            this.cmbUkuran.FormattingEnabled = true;
            this.cmbUkuran.Location = new System.Drawing.Point(178, 134);
            this.cmbUkuran.Name = "cmbUkuran";
            this.cmbUkuran.Size = new System.Drawing.Size(183, 21);
            this.cmbUkuran.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Ukuran Hewan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nama Customer";
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(415, 164);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(120, 43);
            this.btnBatal.TabIndex = 34;
            this.btnBatal.Text = "BATAL";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(541, 164);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(120, 43);
            this.btnSimpan.TabIndex = 33;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // HewanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUkuran);
            this.Controls.Add(this.cmbJenisHewan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtHewan);
            this.Controls.Add(this.label1);
            this.Name = "HewanControl";
            this.Size = new System.Drawing.Size(672, 218);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtHewan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbJenisHewan;
        private System.Windows.Forms.ComboBox cmbUkuran;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
    }
}
