using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
using System.Data.SqlClient;

namespace QuanLyKhachSan
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        /* BusinessLogicLayer bus = new BusinessLogicLayer();
         DataAcessLayer dal = new DataAcessLayer();*/

        private void formLogin_Load(object sender, EventArgs e)
        {

        }


       
        private void tbUserName_MouseLeave(object sender, EventArgs e)
        {
            if (tbUserName.Text == "")
            {
                tbUserName.Text = "Tài khoản";
                tbUserName.ForeColor = Color.Gray;
            }
        }

        private void tbUserName_MouseEnter(object sender, EventArgs e)
        {
            if (tbUserName.Text == "Tài khoản")
            {
                tbUserName.Text = "";
                tbUserName.ForeColor = Color.Blue;
            }
        }

        private void tbMatKhau_MouseLeave(object sender, EventArgs e)
        {
            if (tbMatKhau.Text == "")
            {
                tbMatKhau.Text = "Mật khẩu";
                tbMatKhau.ForeColor = Color.Gray;
            }

        }

        private void tbMatKhau_MouseEnter(object sender, EventArgs e)
        {
            if (tbMatKhau.Text == "Mật khẩu")
            {
                tbMatKhau.Text = "";
                tbMatKhau.ForeColor = Color.Blue;
            }

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string userName = tbUserName.Text.Trim();
            string password = tbMatKhau.Text.Trim();
            if (userName == "" || password == "")
            {
                MessageBox.Show("Bạn chưa điền mật khẩu hoặc password");
            }

            else if (isLogin(userName, password,"user") || isLogin(userName, password," "))
            {
                Home fm = new Home();
                fm.Show();
                this.Hide();
            }
            else if (isLogin(userName, password, "admin"))
            {
                formAdmin fm = new formAdmin();
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }
        public bool isLogin(string userName, string password, string roll)
        {
            return BusinessLogicLayer.Instance.Login(userName, password, roll);
        }


        private void checkBoxShowOrHide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowOrHide.Checked)
            {
                tbMatKhau.UseSystemPasswordChar = false;
                checkBoxShowOrHide.Text = "Hide";
            }
            else   
            {
                tbMatKhau.UseSystemPasswordChar = true;
                checkBoxShowOrHide.Text = "Show password";
            }
        }
    }
    }
