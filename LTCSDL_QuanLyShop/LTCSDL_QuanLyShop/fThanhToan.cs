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
    public partial class fThanhToan : Form
    {

        #region BienHV
        BUS_SanPham bSanPham;
        BUS_KhachHang bKhachHang;
        BUS_HoaDon bHoaDon;
        DataTable dtSanPham;
        bool co = false;
        public int maHD; 
        #endregion
        public fThanhToan()
        {
            InitializeComponent();
            bSanPham = new BUS_SanPham();
            bKhachHang = new BUS_KhachHang();
            bHoaDon = new BUS_HoaDon();
        }

        //public void HienThiGoiY()
        //{
        //    AutoCompleteStringCollection auto2 = new AutoCompleteStringCollection();
        //    string ten = txtSP.Text.Trim();
        //    auto2.Add(bSanPham.HienThiSPTXT(ten));
        //    txtSP.AutoCompleteMode = AutoCompleteMode.Append;
        //    txtSP.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //    txtSP.AutoCompleteCustomSource = auto2;
        //}
        private void fThanhToan_Load(object sender, EventArgs e)
        {
            pnTTSP.Enabled = false;
            gbTTHD.Enabled = false;
            bSanPham.HienThicbbSP(cbbTimSanPham);
            bKhachHang.HienThicbbKH(cbbTenKH);
            lbTongTienHD.Text = "0";
            co = true;

            dtSanPham = new DataTable();
            dtSanPham.Columns.Add("IDCTHD");
            dtSanPham.Columns.Add("TenSP");
            dtSanPham.Columns.Add("SoLuong");
            dtSanPham.Columns.Add("DonGia");
            dtSanPham.Columns.Add("IDSP");
            dgvSPTT.DataSource = dtSanPham;
        }

        private void cbbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            gbTTHD.Enabled = true;
            DataRow r;
            bool ktSP = true;
            ChiTietHoaDon ct = new ChiTietHoaDon();
            foreach (DataRow item in dtSanPham.Rows)
            {
                if (cbbTimSanPham.SelectedValue.ToString() == item[4].ToString())
                {
           
                    ChiTietHoaDon cthd = bHoaDon.HienThiCTHDTheoMa(int.Parse(item[0].ToString()));

                    item[2] = int.Parse(item[2].ToString()) + numSLSP.Value;
                    //lbTongTienHD.Text = (float.Parse(lbTongTienHD.Text) + (ct.DonGia * int.Parse(ct.SoLuong.ToString()))).ToString();

                    ct.IDCTHD = cthd.IDCTHD;
                    ct.SoLuong = int.Parse(item[2].ToString());
                    ct.DonGia = cthd.DonGia;
                    ct.IDSP = cthd.IDSP;
                    ct.IDHD = cthd.IDHD;
                    if (bHoaDon.CatNhatCTHD(ct))
                    {
                        MessageBox.Show("Sản phẩm đã chọn");
                        lbTongTienHD.Text = (float.Parse(lbTongTienHD.Text) + (ct.DonGia * int.Parse(ct.SoLuong.ToString()))).ToString();
                    }
                    else
                        MessageBox.Show("Sản phẩm không thành công");
                    ktSP = false;
                    break;
                }
            }
            if (ktSP)
            {
                ct.SoLuong = int.Parse(numSLSP.Value.ToString());
                ct.DonGia = int.Parse(txtDonGiaSP.Text);
                ct.IDSP = int.Parse(cbbTimSanPham.SelectedValue.ToString());
                ct.IDHD = int.Parse(lbIDHD.Text);
                if (bHoaDon.ThemCTHD(ct))
                {
                    r = dtSanPham.NewRow();
                    r[0] = ct.IDCTHD;
                    r[1] = cbbTimSanPham.Text;
                    r[2] = numSLSP.Value;
                    r[3] = txtDonGiaSP.Text;
                    r[4] = int.Parse(cbbTimSanPham.SelectedValue.ToString());
                    dtSanPham.Rows.Add(r);
                    dgvSPTT.DataSource = dtSanPham;
                    lbTongTienHD.Text = (float.Parse(lbTongTienHD.Text) + (ct.DonGia * int.Parse(ct.SoLuong.ToString()))).ToString();
                }
                else
                    MessageBox.Show("Thêm sản phẩm không thành công");
            }    
            

        }
        private void btnTaoKH_Click(object sender, EventArgs e)
        {
            pnTTSP.Enabled = true;
            KhachHang kh = new KhachHang();
            kh.IDKH = int.Parse(cbbTenKH.SelectedValue.ToString());
            kh.TenKH = cbbTenKH.Text;
            kh.SDT = txtSDTKH.Text;
            if(bKhachHang.ThemKH(kh))
            {
                MessageBox.Show("Tạo thành công");
                HoaDon hd = new HoaDon();
                hd.NgayLap = DateTime.Now;
                hd.TongTien = 0;
                hd.IDKH = kh.IDKH;
                if (bHoaDon.ThemHD(hd))
                {
                    lbIDHD.Text = hd.IDHD.ToString();
                }
                else
                {
                    MessageBox.Show("Tạo hóa đơn thất bại");
                }    
            }
            else
            {
                MessageBox.Show("Tạo thất bại");
            }    
        }

        private void XóaSP_Click(object sender, EventArgs e)
        {
            if(this.dgvSPTT.SelectedRows.Count > 0)
            {
                int index = dgvSPTT.CurrentCell.RowIndex;
                int ma = Int32.Parse(dgvSPTT.Rows[index].Cells[0].Value.ToString());
                ChiTietHoaDon ct = bHoaDon.HienThiCTHDTheoMa(ma);
                if (bHoaDon.XoaCTHD(ma))
                {
                    MessageBox.Show("Xóa thành công");
                    lbTongTienHD.Text = (float.Parse(lbTongTienHD.Text) - (ct.DonGia * int.Parse(ct.SoLuong.ToString()))).ToString();
                    dgvSPTT.Rows.RemoveAt(this.dgvSPTT.SelectedRows[0].Index);
                }
                else
                    MessageBox.Show("Xóa thất bại");
            }    
        }

        private void txtSoTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            string tiendua = txtSoTienKhachDua.Text;
            string tientra = lbTongTienHD.Text;
            if (txtSoTienKhachDua.Text == tiendua)
            {
                txtSoTienTraKhach.Text = (int.Parse(tiendua) - int.Parse(tientra)).ToString();
            }
            else
            {
                if (txtSoTienKhachDua.Text == tiendua)
                {
                    txtSoTienTraKhach.Text = "0";
                }
            }
        }

        private void cbbTimSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            SanPham s;
            int ma;
            
            if(co)
            {     
                ma = int.Parse(cbbTimSanPham.SelectedValue.ToString());
                s = bSanPham.HienThiSPTheoMa(ma);
                txtDonGiaSP.Text = s.GiaBan.ToString();
            }


        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            pnTTSP.Enabled = false;
            gbTTHD.Enabled = false;
            HoaDon h = new HoaDon();
            h.IDHD = int.Parse(lbIDHD.Text);
            h.NgayLap = DateTime.Now;
            h.TongTien = float.Parse(lbTongTienHD.Text);
            h.IDKH = int.Parse(cbbTenKH.SelectedValue.ToString());
            if (bHoaDon.CapNhatHD(h))
            {
                MessageBox.Show("Thanh toán thành công");
                fThongTinHoaDon f = new fThongTinHoaDon();
                f.IDHD = h.IDHD;
                this.Hide();
                f.ShowDialog();
                lbIDHD.Text = " ";
                lbTongTienHD.Text = " ";
                cbbTenKH.Text = " ";
            }    
            else
            {
                MessageBox.Show("Thanh toán thất bại");
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát chương trình không???");
            fTrangChu f = new fTrangChu();
            this.Hide();
            f.ShowDialog();
        }

        private void cbbTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            KhachHang kh;
            int maKH;
            if (co)
            {
                maKH = Int32.Parse(cbbTenKH.SelectedValue.ToString());
                kh = bKhachHang.HienTTKHTheoMa(maKH);
                txtSDTKH.Text = kh.SDT.ToString();
            }
        }
    }
    
}
