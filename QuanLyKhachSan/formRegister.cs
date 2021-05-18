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

namespace QuanLyKhachSan
{
    public partial class formRegister : Form
    {
        public formRegister()
        {
            InitializeComponent();
        }

        private void formRegister_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtRgUserName.Text.Trim();
            string password = txtRgPassword.Text.Trim();
            string roll = "user";

            if (!isValidate(userName, password)) return;

            isRegister(userName, password, roll);
            MessageBox.Show("Đăng ký thành công", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Home fm = new Home();
            fm.Show();
            this.Hide();

        }

        private bool isRegister(string userName, string password, string roll)
        {
            return BusinessLogicLayer.Instance.Register(userName, password, roll);
        }

        private bool isValidate(string userName, string password)
        {
            if(userName.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Tên tài khoản hoăc mật khẩu không hợp lệ!!!");
                return false;
            }
            return true;
        }
    }
}
