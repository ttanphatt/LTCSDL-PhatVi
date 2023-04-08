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
    public partial class fChiTietPhieuNhap : Form
    {
        
        public int IDPN;
        public double tongtien;
        BUS_PhieuNhap bPhieuNhap;
        BUS_SanPham bSanPham;
        
        public fChiTietPhieuNhap()
        {
            InitializeComponent();
            bPhieuNhap = new BUS_PhieuNhap();
            bSanPham = new BUS_SanPham();
        }
        public void HienThiChiTietPhieuNhap(int IDPN)
        {
            dgvCTPN.DataSource = null;
            bPhieuNhap.HienThiChiTietPhieuNhap(dgvCTPN, IDPN);
            dgvCTPN.Columns[0].Width = (int)(dgvCTPN.Width * 0.1);
            dgvCTPN.Columns[1].Width = (int)(dgvCTPN.Width * 0.225);
            dgvCTPN.Columns[2].Width = (int)(dgvCTPN.Width * 0.225);
            dgvCTPN.Columns[3].Width = (int)(dgvCTPN.Width * 0.225);
            dgvCTPN.Columns[4].Width = (int)(dgvCTPN.Width * 0.225);
        }
        public void HienThicbbSP()
        {
            bSanPham.HienThicbbSP(cbbTenSP);
        }
        private void fChiTietPhieuNhap_Load(object sender, EventArgs e)
        {

            PhieuNhap pn = bPhieuNhap.HienThiPNtheoID(IDPN);
            txtTongTienNhap.Text = pn.TongTien.ToString();
            txtIDPN.Text = IDPN.ToString();
            txtTongTienNhap.Text = "0";
            bPhieuNhap.HienThiChiTietPhieuNhap(dgvCTPN, IDPN);
            HienThicbbSP();
        }

        private void btThemCTPN_Click(object sender, EventArgs e)
        {
            
            ChiTietPN ct = new ChiTietPN();
            ct.IDPN = IDPN;
            ct.IDSP = int.Parse(cbbTenSP.SelectedValue.ToString());
            ct.SoLuong = Convert.ToInt32(numSLNhap.Value);
            ct.DonGia = float.Parse(txtGiaNhap.Text.ToString());
            txtTongTienNhap.Text = (float.Parse(txtTongTienNhap.Text) + (ct.DonGia * float.Parse(ct.SoLuong.ToString()))).ToString();
            //txtTongTienNhap.Text = (float.Parse(txtTongTienNhap.ToString()) + (float.Parse(numSLNhap.Value.ToString()) * float.Parse(txtGiaNhap.Text.ToString()))).ToString();
            if (bPhieuNhap.ThemCTPN(ct))
            {

                bPhieuNhap.HienThiChiTietPhieuNhap(dgvCTPN, IDPN);
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại");
            }
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            PhieuNhap pn = bPhieuNhap.HienThiPNtheoID(int.Parse(txtIDPN.Text.ToString()));
            PhieuNhap p = new PhieuNhap();
            p.IDPN = pn.IDPN;
            p.TenPN = pn.TenPN;
            p.NgayNhap = pn.NgayNhap;
            p.IDNCC = pn.IDNCC;
            p.IDNV = pn.IDNV;
            p.TongTien = float.Parse(txtTongTienNhap.Text.ToString());
            if (bPhieuNhap.SuaPN(p))
            {
                MessageBox.Show("Lưu thành công");
                bPhieuNhap.HienThiPNtheoID(IDPN);
                //bPhieuNhap.HienThiPN(dgvPhieuNhap);

            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
