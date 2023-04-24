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
    
    public partial class fTrangChu : Form
    {
        public int IDAcc;
        bool flag = false;
        BUS_NhanVien bNhanVien;
        public fTrangChu()
        {
            InitializeComponent();
            bNhanVien = new BUS_NhanVien();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }


        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThanhToan f = new fThanhToan();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void fTrangChu_MouseClick(object sender, MouseEventArgs e)
        {
            if (flag == false)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                flag = true;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.WindowState = FormWindowState.Normal;
                flag = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        public void HienThiThongNV()
        {
            NhanVien nv = bNhanVien.HienThiNVTheoMa(IDAcc);
            lbHoTen.Text = nv.TenNV;
            lbSDT.Text = nv.SDT.ToString();
        }
        private void fTrangChu_Load(object sender, EventArgs e)
        {
            lbIDNV.Text = IDAcc.ToString();
            HienThiThongNV();

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có thực sự muốn thoát chương trình?");
            fLogin f = new fLogin();
            this.Hide();
            f.ShowDialog();
        }
    }
}
