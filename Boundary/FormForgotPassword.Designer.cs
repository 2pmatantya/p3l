namespace Kouvee_Pet_Shop.Boundary
{
    partial class FormForgotPassword
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
            this.btncancel = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.txtnotelp = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtkonfirm = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(245, 167);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 15;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(129, 167);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(75, 23);
            this.btnUbah.TabIndex = 14;
            this.btnUbah.Text = "Update";
            this.btnUbah.UseVisualStyleBackColor = true;
            // 
            // txtnotelp
            // 
            this.txtnotelp.Location = new System.Drawing.Point(129, 56);
            this.txtnotelp.Name = "txtnotelp";
            this.txtnotelp.Size = new System.Drawing.Size(206, 20);
            this.txtnotelp.TabIndex = 8;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(129, 86);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(206, 20);
            this.txtpassword.TabIndex = 10;
            // 
            // txtkonfirm
            // 
            this.txtkonfirm.Location = new System.Drawing.Point(129, 123);
            this.txtkonfirm.Name = "txtkonfirm";
            this.txtkonfirm.Size = new System.Drawing.Size(206, 20);
            this.txtkonfirm.TabIndex = 12;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(129, 21);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(206, 20);
            this.txtuser.TabIndex = 6;
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Konfirmasi Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password Baru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "No Telepon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username";
            // 
            // FormForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 207);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.txtnotelp);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtkonfirm);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormForgotPassword";
            this.Text = "Lupa Password?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.TextBox txtnotelp;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtkonfirm;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}