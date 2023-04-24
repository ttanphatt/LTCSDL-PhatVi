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
    public partial class fThongTinHoaDon : Form
    {
        public int IDHD;
        BUS_HoaDon bHoaDon;
        BUS_KhachHang bKhachHang;
        public fThongTinHoaDon()
        {
            InitializeComponent();
            bHoaDon = new BUS_HoaDon();
            bKhachHang = new BUS_KhachHang();
        }

        private void fThongTinHoaDon_Load(object sender, EventArgs e)
        {
            
            HoaDon hd = bHoaDon.HienThiHDTheoMa(IDHD);
            KhachHang kh = bKhachHang.HienTTKHTheoMa(hd.IDKH);
            lbIDHD.Text = IDHD.ToString();
            lbTongTien.Text = hd.TongTien.ToString();
            lbSDT.Text = kh.SDT.ToString();
            lbTenKH.Text = kh.TenKH;
            bHoaDon.HienThiDSCTHD(dgvCTSP, IDHD);
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát không??");
            fThanhToan f = new fThanhToan();
            this.Hide();
            f.ShowDialog();

        }
    }
}
