namespace GetMD5
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_md5 = new System.Windows.Forms.TextBox();
            this.textbox_sha1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_sha256 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_sha384 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_sha512 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_ripemd160 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Hash From File";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(776, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textbox_ripemd160);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textbox_sha512);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textbox_sha384);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textbox_sha256);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textbox_sha1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textbox_md5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 110);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(776, 328);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "MD5 Hash Sum";
            // 
            // textbox_md5
            // 
            this.textbox_md5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_md5.ForeColor = System.Drawing.Color.Red;
            this.textbox_md5.Location = new System.Drawing.Point(11, 26);
            this.textbox_md5.Name = "textbox_md5";
            this.textbox_md5.ReadOnly = true;
            this.textbox_md5.Size = new System.Drawing.Size(755, 27);
            this.textbox_md5.TabIndex = 1;
            // 
            // textbox_sha1
            // 
            this.textbox_sha1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_sha1.ForeColor = System.Drawing.Color.Red;
            this.textbox_sha1.Location = new System.Drawing.Point(11, 77);
            this.textbox_sha1.Name = "textbox_sha1";
            this.textbox_sha1.ReadOnly = true;
            this.textbox_sha1.Size = new System.Drawing.Size(755, 27);
            this.textbox_sha1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "SHA1 Hash Sum";
            // 
            // textbox_sha256
            // 
            this.textbox_sha256.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_sha256.ForeColor = System.Drawing.Color.Red;
            this.textbox_sha256.Location = new System.Drawing.Point(11, 128);
            this.textbox_sha256.Name = "textbox_sha256";
            this.textbox_sha256.ReadOnly = true;
            this.textbox_sha256.Size = new System.Drawing.Size(755, 27);
            this.textbox_sha256.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "SHA256 Hash Sum";
            // 
            // textbox_sha384
            // 
            this.textbox_sha384.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_sha384.ForeColor = System.Drawing.Color.Red;
            this.textbox_sha384.Location = new System.Drawing.Point(11, 179);
            this.textbox_sha384.Name = "textbox_sha384";
            this.textbox_sha384.ReadOnly = true;
            this.textbox_sha384.Size = new System.Drawing.Size(755, 27);
            this.textbox_sha384.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "SHA384 Hash Sum";
            // 
            // textbox_sha512
            // 
            this.textbox_sha512.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_sha512.ForeColor = System.Drawing.Color.Red;
            this.textbox_sha512.Location = new System.Drawing.Point(11, 230);
            this.textbox_sha512.Name = "textbox_sha512";
            this.textbox_sha512.ReadOnly = true;
            this.textbox_sha512.Size = new System.Drawing.Size(755, 27);
            this.textbox_sha512.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "SHA512 Hash Sum";
            // 
            // textbox_ripemd160
            // 
            this.textbox_ripemd160.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_ripemd160.ForeColor = System.Drawing.Color.Red;
            this.textbox_ripemd160.Location = new System.Drawing.Point(11, 281);
            this.textbox_ripemd160.Name = "textbox_ripemd160";
            this.textbox_ripemd160.ReadOnly = true;
            this.textbox_ripemd160.Size = new System.Drawing.Size(755, 27);
            this.textbox_ripemd160.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "RIPEMD160 Hash Sum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get Hash From File";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textbox_md5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_ripemd160;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textbox_sha512;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbox_sha384;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbox_sha256;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textbox_sha1;
        private System.Windows.Forms.Label label3;
    }
}

