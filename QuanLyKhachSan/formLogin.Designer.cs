
namespace QuanLyKhachSan
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxShowOrHide = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên tài khoản";
            // 
            // tbUserName
            // 
            this.tbUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbUserName.Location = new System.Drawing.Point(130, 51);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(154, 20);
            this.tbUserName.TabIndex = 3;
            this.tbUserName.MouseEnter += new System.EventHandler(this.tbUserName_MouseEnter);
            this.tbUserName.MouseLeave += new System.EventHandler(this.tbUserName_MouseLeave);
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbMatKhau.Location = new System.Drawing.Point(130, 119);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(154, 20);
            this.tbMatKhau.TabIndex = 4;
            this.tbMatKhau.UseSystemPasswordChar = true;
            this.tbMatKhau.MouseEnter += new System.EventHandler(this.tbMatKhau_MouseEnter);
            this.tbMatKhau.MouseLeave += new System.EventHandler(this.tbMatKhau_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.checkBoxShowOrHide);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnDangNhap);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbMatKhau);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbUserName);
            this.panel1.Location = new System.Drawing.Point(63, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 245);
            this.panel1.TabIndex = 5;
            // 
            // checkBoxShowOrHide
            // 
            this.checkBoxShowOrHide.AutoSize = true;
            this.checkBoxShowOrHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShowOrHide.Location = new System.Drawing.Point(130, 156);
            this.checkBoxShowOrHide.Name = "checkBoxShowOrHide";
            this.checkBoxShowOrHide.Size = new System.Drawing.Size(101, 17);
            this.checkBoxShowOrHide.TabIndex = 11;
            this.checkBoxShowOrHide.Text = "Show password";
            this.checkBoxShowOrHide.UseVisualStyleBackColor = true;
            this.checkBoxShowOrHide.CheckedChanged += new System.EventHandler(this.checkBoxShowOrHide_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyKhachSan.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(91, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDangNhap.Location = new System.Drawing.Point(28, 179);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(321, 32);
            this.btnDangNhap.TabIndex = 9;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(144, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quên mật khẩu?\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::QuanLyKhachSan.Properties.Resources.fgp;
            this.pictureBox1.Location = new System.Drawing.Point(91, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật khẩu";
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 284);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.formLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBoxShowOrHide;
    }
}