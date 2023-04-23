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

        #region BienHV
        public int IDPN;
        public double tongtien;
        BUS_PhieuNhap bPhieuNhap;
        BUS_SanPham bSanPham;
        DataTable dtPhieuNhap;
        bool co = false;
        #endregion


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
            HienThicbbSP();
            co = true;
            PhieuNhap pn = bPhieuNhap.HienThiPNtheoID(IDPN);
            txtTongTienNhap.Text = pn.TongTien.ToString();
            txtIDPN.Text = IDPN.ToString();
            bPhieuNhap.HienThiChiTietPhieuNhap(dgvCTPN, IDPN);
            

             
        }

        private void btThemCTPN_Click(object sender, EventArgs e)
        {
            bool ktSanPham = true;
            ChiTietPN ct = new ChiTietPN();

            for (int i = 0; i < dgvCTPN.Rows.Count; i++)
            {
                ChiTietPN ctpn = bPhieuNhap.LayCTPN(int.Parse(dgvCTPN.Rows[i].Cells[0].Value.ToString()));
                if (Int32.Parse(cbbTenSP.SelectedValue.ToString()) == ctpn.IDSP)
                {
                    
                    ct.IDCTPN = ctpn.IDCTPN;
                    ct.IDPN = IDPN;
                    ct.IDSP = ctpn.IDSP;
                    ct.SoLuong = ctpn.SoLuong + Int32.Parse(numSLNhap.Value.ToString());
                    ct.DonGia = ctpn.DonGia;
                    txtTongTienNhap.Text = (float.Parse(txtTongTienNhap.Text) + (ct.DonGia * float.Parse(ct.SoLuong.ToString()))).ToString();
                    if (bPhieuNhap.CatNhatCTPN(ct))
                    {
                        bPhieuNhap.HienThiChiTietPhieuNhap(dgvCTPN, IDPN);
                        MessageBox.Show("Sản phẩm đã chọn");
                    }
                    else
                        MessageBox.Show("Thất bại");
                    ktSanPham = false;
                    break;
                }
            }

            if (ktSanPham)
            {
                ct.IDCTPN = 
                ct.IDPN = IDPN;
                ct.IDSP = int.Parse(cbbTenSP.SelectedValue.ToString());
                ct.SoLuong = Convert.ToInt32(numSLNhap.Value);
                ct.DonGia = float.Parse(txtGiaNhap.Text.ToString());
                txtTongTienNhap.Text = (float.Parse(txtTongTienNhap.Text) + (ct.DonGia * float.Parse(ct.SoLuong.ToString()))).ToString();
                if (bPhieuNhap.ThemCTPN(ct))
                {

                    bPhieuNhap.HienThiChiTietPhieuNhap(dgvCTPN, IDPN);
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại");
                } 
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
        private void cbbTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            SanPham sp;
            int maSanPham;
            if(co)
            {
                maSanPham = int.Parse(cbbTenSP.SelectedValue.ToString());
                sp = bSanPham.HienThiSPTheoMa(maSanPham);
                txtGiaNhap.Text = sp.GiaBan.ToString();
            }    
        }

        private void btnXoaCTPN_Click(object sender, EventArgs e)
        {
            if(this.dgvCTPN.SelectedRows.Count > 0)
            {
                ChiTietPN ct = new ChiTietPN();
                int index = dgvCTPN.CurrentCell.RowIndex;
                ct.IDCTPN = int.Parse(dgvCTPN.Rows[index].Cells["IDHD"].Value.ToString());
                ChiTietPN c = bPhieuNhap.LayCTPN(ct.IDCTPN);
                txtTongTienNhap.Text = (float.Parse(txtTongTienNhap.Text) - (c.DonGia * int.Parse(c.SoLuong.ToString()))).ToString();
                if (bPhieuNhap.XoaCTPN(ct))
                {
                    bPhieuNhap.HienThiChiTietPhieuNhap(dgvCTPN, IDPN);
                    MessageBox.Show("Xóa thành công");
                }
            }    
            
            else
                MessageBox.Show("Xóa thất bại");
        }
    }
}
