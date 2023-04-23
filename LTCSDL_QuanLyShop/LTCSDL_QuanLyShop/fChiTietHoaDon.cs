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
    public partial class fChiTietHoaDon : Form
    {
        public int IDHD;
        BUS_HoaDon bHoaDon;
        public fChiTietHoaDon()
        {
            InitializeComponent();
            bHoaDon = new BUS_HoaDon();
        }
        public void HienThiDSCTHD()
        {
            dgvCTHD.DataSource = null;
            bHoaDon.HienThiDSCTHD(dgvCTHD, IDHD);
        }
        private void fChiTietHoaDon_Load(object sender, EventArgs e)
        {
            HoaDon hd = bHoaDon.HienThiHDTheoMa(IDHD);
            txtIDHD.Text = hd.IDHD.ToString();
            bHoaDon.HienThiDSCTHD(dgvCTHD, IDHD);
        }
    }
}
