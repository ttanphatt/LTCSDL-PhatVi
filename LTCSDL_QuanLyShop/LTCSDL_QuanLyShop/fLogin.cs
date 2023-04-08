using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LTCSDL_QuanLyShop.BUS;

namespace LTCSDL_QuanLyShop
{
    public partial class fLogin : Form
    {
        BUS_Login bLogin = new BUS_Login();
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }
        bool Login(string username, string password)
        {
            txtUserName.Text = "";
            txtPassWord.Text = "";
            return bLogin.Login(username, password);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassWord.Text;
            if (Login(username, password))
            {
                fTrangChu f = new fTrangChu();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Bạn vui lòng nhập lại tên đăng nhập và mật khẩu");
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
