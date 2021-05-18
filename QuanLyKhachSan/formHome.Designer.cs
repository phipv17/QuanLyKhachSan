
namespace QuanLyKhachSan
{
    partial class Home
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
            this.listPhong = new System.Windows.Forms.DataGridView();
            this.cboxLoaiPhong = new System.Windows.Forms.ComboBox();
            this.dateTimeCheckIn = new System.Windows.Forms.DateTimePicker();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimeCheckOut = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.listPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listPhong
            // 
            this.listPhong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listPhong.Location = new System.Drawing.Point(12, 255);
            this.listPhong.Name = "listPhong";
            this.listPhong.Size = new System.Drawing.Size(764, 401);
            this.listPhong.TabIndex = 0;
            // 
            // cboxLoaiPhong
            // 
            this.cboxLoaiPhong.FormattingEnabled = true;
            this.cboxLoaiPhong.Location = new System.Drawing.Point(569, 143);
            this.cboxLoaiPhong.Name = "cboxLoaiPhong";
            this.cboxLoaiPhong.Size = new System.Drawing.Size(52, 21);
            this.cboxLoaiPhong.TabIndex = 2;
            // 
            // dateTimeCheckIn
            // 
            this.dateTimeCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimeCheckIn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimeCheckIn.Location = new System.Drawing.Point(15, 8);
            this.dateTimeCheckIn.Name = "dateTimeCheckIn";
            this.dateTimeCheckIn.Size = new System.Drawing.Size(200, 20);
            this.dateTimeCheckIn.TabIndex = 3;
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangKy.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDangKy.Location = new System.Drawing.Point(579, 25);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(75, 37);
            this.btnDangKy.TabIndex = 4;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDangNhap.Location = new System.Drawing.Point(677, 25);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(75, 37);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VNI-Jamai", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 65);
            this.label1.TabIndex = 6;
            this.label1.Text = "MY HOTEL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyKhachSan.Properties.Resources.contact;
            this.pictureBox1.Location = new System.Drawing.Point(410, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contact for booking";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.dateTimeCheckOut);
            this.panel1.Controls.Add(this.dateTimeCheckIn);
            this.panel1.Location = new System.Drawing.Point(26, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 38);
            this.panel1.TabIndex = 9;
            // 
            // dateTimeCheckOut
            // 
            this.dateTimeCheckOut.CalendarTrailingForeColor = System.Drawing.Color.GhostWhite;
            this.dateTimeCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimeCheckOut.Location = new System.Drawing.Point(274, 8);
            this.dateTimeCheckOut.Name = "dateTimeCheckOut";
            this.dateTimeCheckOut.Size = new System.Drawing.Size(200, 20);
            this.dateTimeCheckOut.TabIndex = 4;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.b1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(779, 668);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.cboxLoaiPhong);
            this.Controls.Add(this.listPhong);
            this.Name = "Home";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.listPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listPhong;
        private System.Windows.Forms.ComboBox cboxLoaiPhong;
        private System.Windows.Forms.DateTimePicker dateTimeCheckIn;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimeCheckOut;
    }
}

