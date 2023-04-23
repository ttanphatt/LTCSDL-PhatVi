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
    public partial class fAdmin : Form
    {
        BUS_SanPham bSanPham;
        BUS_NhanVien bNhanVien;
        BUS_Account bAccount;
        BUS_KhachHang bKhachHang;
        BUS_PhieuNhap bPhieuNhap;
        BUS_HoaDon bHoaDon;
        public fAdmin()
        {
            InitializeComponent();
            bSanPham = new BUS_SanPham();
            bNhanVien = new BUS_NhanVien();
            bAccount = new BUS_Account();
            bKhachHang = new BUS_KhachHang();
            bPhieuNhap = new BUS_PhieuNhap();
            bHoaDon = new BUS_HoaDon();
        }
        public void HienThiSanPham()
        {
            dgvSanPham.DataSource = null;
            bSanPham.HienThiSP(dgvSanPham);
            dgvSanPham.Columns[0].Width = (int)(dgvSanPham.Width * 0.05);
            dgvSanPham.Columns[1].Width = (int)(dgvSanPham.Width * 0.19);
            dgvSanPham.Columns[2].Width = (int)(dgvSanPham.Width * 0.19);
            dgvSanPham.Columns[3].Width = (int)(dgvSanPham.Width * 0.19);
            dgvSanPham.Columns[4].Width = (int)(dgvSanPham.Width * 0.19);
            dgvSanPham.Columns[5].Width = (int)(dgvSanPham.Width * 0.19);
        }
        public void HienThiNhanVien()
        {
            dgvNhanVien.DataSource = null;
            bNhanVien.HienThiNV(dgvNhanVien);
            dgvNhanVien.Columns[0].Width = (int)(dgvNhanVien.Width * 0.1);
            dgvNhanVien.Columns[1].Width = (int)(dgvNhanVien.Width * 0.3);
            dgvNhanVien.Columns[2].Width = (int)(dgvNhanVien.Width * 0.3);
            dgvNhanVien.Columns[3].Width = (int)(dgvNhanVien.Width * 0.3);
        }
        public void HienThiAccount()
        {
            dgvAccount.DataSource = null;
            bAccount.HienThiAcc(dgvAccount);
            dgvAccount.Columns[0].Width = (int)(dgvAccount.Width * 0.1);
            dgvAccount.Columns[1].Width = (int)(dgvAccount.Width * 0.45);
            dgvAccount.Columns[2].Width = (int)(dgvAccount.Width * 0.45);
        }
        public void HienThiKhachHang()
        {
            dgvKhachHang.DataSource = null;
            bKhachHang.HienThiKH(dgvKhachHang);
            dgvKhachHang.Columns[0].Width = (int)(dgvKhachHang.Width * 0.1);
            dgvKhachHang.Columns[1].Width = (int)(dgvKhachHang.Width * 0.45);
            dgvKhachHang.Columns[2].Width = (int)(dgvKhachHang.Width * 0.45);
        }
        public void HienThiPhieuNhap()
        {
            dgvPhieuNhap.DataSource = null;
            bPhieuNhap.HienThiPN(dgvPhieuNhap);
            dgvPhieuNhap.Columns[0].Width = (int)(dgvPhieuNhap.Width * 0.05);
            dgvPhieuNhap.Columns[1].Width = (int)(dgvPhieuNhap.Width * 0.19);
            dgvPhieuNhap.Columns[2].Width = (int)(dgvPhieuNhap.Width * 0.19);
            dgvPhieuNhap.Columns[3].Width = (int)(dgvPhieuNhap.Width * 0.19);
            dgvPhieuNhap.Columns[4].Width = (int)(dgvPhieuNhap.Width * 0.19);
            dgvPhieuNhap.Columns[5].Width = (int)(dgvPhieuNhap.Width * 0.19);
        }
        public void HienThiHoaDon()
        {
            dgvHoaDon.DataSource = null;
            bHoaDon.HienThiDSHD(dgvHoaDon);
        }
        public void HienThicbbSanPham()
        {
            bSanPham.HienThicbbSP(cbbTimTenSP);
        }
        public void HienThicbbNhanVien()
        {
            bNhanVien.HienThicbbNV(cbbTimTenNV);
        }
        public void HienThicbbNhaCungCap()
        {
            bSanPham.HienThicbbNCC(cbbNCC);
        }
        public void HienThicbbPhieuNhap()
        {
            bPhieuNhap.HienThicbbPN(cbbTimTenPN);
        }
        public void HienThicbbAccount()
        {
            bAccount.HienThicbbAcc(cbbTimTK);
        }
        public void HienThicbbKhachHang()
        {
            bKhachHang.HienThicbbKH(cbbTimTeNKHHD);
        }
        public void HienThicbbHDKH()
        {
            bKhachHang.HienThicbbKH(cbbTimTeNKHHD);
        }
            private void fAdmin_Load(object sender, EventArgs e)
        {
            HienThiSanPham();
            HienThicbbSanPham();
            HienThiNhanVien();
            HienThicbbNhanVien();
            HienThicbbNhaCungCap();
            HienThiAccount();
            HienThicbbAccount();
            HienThiKhachHang();
            HienThiPhieuNhap();
            HienThicbbPhieuNhap();
            HienThiHoaDon();
            HienThicbbKhachHang();
            HienThicbbHDKH();
            txtTienNhap.Text =  "0";
        }
        // ==================== DGV CellClick   ===================
        private void dgvSanPham_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSanPham.Rows.Count)
            {
                txtIDSP.Text = dgvSanPham.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenSP.Text = dgvSanPham.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSLKho.Text = dgvSanPham.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMau.Text = dgvSanPham.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtXX.Text = dgvSanPham.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtGia.Text = dgvSanPham.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }
        
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvNhanVien.Rows.Count)
            {
                txtIDNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSDT.Text = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtLuong.Text = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvAccount.Rows.Count)
            {
                txtIDAcc.Text = dgvAccount.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtUN.Text = dgvAccount.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPW.Text = dgvAccount.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvKhachHang.Rows.Count)
            {
                txtIDKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvPhieuNhap.Rows.Count)
            {
                txtIDPN.Text = dgvPhieuNhap.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenPN.Text = dgvPhieuNhap.Rows[e.RowIndex].Cells[1].Value.ToString();
                dateNgayNhap.Text = dgvPhieuNhap.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbbNCC.Text = dgvPhieuNhap.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbbNV.Text = dgvPhieuNhap.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtTienNhap.Text = dgvPhieuNhap.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }
        // ============   THÊM      ================
        private void btThem_Click_1(object sender, EventArgs e)
        {
            SanPham sanPham = new SanPham();
            sanPham.TenSP = txtTenSP.Text;
            sanPham.SLKho = int.Parse(txtSLKho.Text.ToString());
            sanPham.MauSac = txtMau.Text;
            sanPham.XuatXu = txtXX.Text.ToString();
            sanPham.GiaBan = float.Parse(txtGia.Text.ToString());

            if (bSanPham.ThemSP(sanPham))
            {

                MessageBox.Show("Thêm sản phẩm thành công");
                bSanPham.HienThiSP(dgvSanPham);
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại");
            }
        }
        private void btThemNV_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.TenNV = txtTenNV.Text;
            nv.SDT = int.Parse(txtSDT.Text.ToString());
            nv.Luong = float.Parse(txtLuong.Text.ToString());
            if (bNhanVien.ThemNV(nv))
            {

                MessageBox.Show("Thêm nhân viên mới thành công");
                bNhanVien.HienThiNV(dgvNhanVien);
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại");
            }
        }
        private void btThemAcc_Click(object sender, EventArgs e)
        {
            Account ac = new Account();
            ac.TenTK = txtUN.Text;
            ac.PassTK = int.Parse(txtPW.Text.ToString());
            if (bAccount.ThemAcc(ac))
            {
                MessageBox.Show("Thêm tài khoản account mới thành công");
                bAccount.HienThiAcc(dgvAccount);
            }
            else
            {
                MessageBox.Show("Thêm account thất bại");
            }
        }
        //private void btThemKH_Click(object sender, EventArgs e)
        //{
        //    KhachHang kh = new KhachHang();
        //    kh.TenKH = txtTenKH.Text;
        //    if (bKhachHang.ThemKH(kh))
        //    {
        //        MessageBox.Show("Thêm khách hàng mới thành công");
        //        bKhachHang.HienThiKH(dgvKhachHang);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Thêm khách hàng thất bại");
        //    }
        //}
        private void btThemPN_Click(object sender, EventArgs e)
        {
            PhieuNhap pn = new PhieuNhap();
            pn.TenPN = txtTenPN.Text;
            pn.NgayNhap = dateNgayNhap.Value;
            pn.IDNCC = int.Parse(cbbNCC.SelectedValue.ToString());
            pn.IDNV = int.Parse(cbbNV.SelectedValue.ToString());
            pn.TongTien = float.Parse(txtTienNhap.Text.ToString());
            if (bPhieuNhap.ThemPN(pn))
            {
                MessageBox.Show("Thêm phiếu nhập thành công");
                bPhieuNhap.HienThiPN(dgvPhieuNhap);
            }
            else
            {
                MessageBox.Show("Thêm phiếu nhập thất bại");
            }
        }



        // ================== SỬA  ==========================
        private void btSua_Click_1(object sender, EventArgs e)
        {
            SanPham sanPham = new SanPham();
            sanPham.IDSP = int.Parse(txtIDSP.Text);
            sanPham.TenSP = txtTenSP.Text;
            sanPham.SLKho = int.Parse(txtSLKho.Text);
            sanPham.MauSac = txtMau.Text;
            sanPham.XuatXu = txtXX.Text.ToString();
            sanPham.GiaBan = float.Parse(txtGia.Text);

            if (bSanPham.SuaSP(sanPham))

            {
                MessageBox.Show("Sửa sản phẩm thành công");
                bSanPham.HienThiSP(dgvSanPham);
            }
            else
            {
                MessageBox.Show("Sửa sản phẩm thất bại");
            }
        }
        
        private void btSuaNV_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.IDNV = int.Parse(txtIDNV.Text);
            nv.TenNV = txtTenNV.Text;
            nv.SDT = int.Parse(txtSDT.Text.ToString());
            nv.Luong = float.Parse(txtLuong.Text.ToString());

            if (bNhanVien.SuaNV(nv))

            {
                MessageBox.Show("Sửa thông tin nhân viên thành công");
                bNhanVien.HienThiNV(dgvNhanVien);
            }
            else
            {
                MessageBox.Show("Sửa nhân viên thất bại");
            }
        }
        private void btSuaAcc_Click(object sender, EventArgs e)
        {
            Account ac = new Account();
            ac.IDAcc = int.Parse(txtIDAcc.Text);
            ac.TenTK = txtUN.Text;
            ac.PassTK = int.Parse(txtPW.Text.ToString());
            if (bAccount.SuaAcc(ac))
            {
                MessageBox.Show("Sửa thông tin tài khoản thành công");
                bAccount.HienThiAcc(dgvAccount);
            }
            else
            {
                MessageBox.Show("Sửa thông tin tài khoản thất bại");
            }
        }
        private void btSuaKH_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.IDKH = int.Parse(txtIDKH.Text);
            kh.TenKH = txtTenKH.Text;
            if (bKhachHang.SuaKH(kh))
            {
                MessageBox.Show("Sửa thông tin khách hàng thành công");
                bKhachHang.HienThiKH(dgvKhachHang);
            }
            else
            {
                MessageBox.Show("Sửa khách hàng thất bại");
            }
        }

        private void btSuaPN_Click(object sender, EventArgs e)
        {
            PhieuNhap pn = new PhieuNhap();
            pn.IDPN = int.Parse(txtIDPN.Text);
            pn.TenPN = txtTenPN.Text;
            pn.NgayNhap = dateNgayNhap.Value;
            pn.IDNCC = int.Parse(cbbNCC.SelectedValue.ToString());
            pn.IDNV = int.Parse(cbbNV.SelectedValue.ToString());
            //pn.TongTien = float.Parse(txtTienNhap.Text.ToString());
            if (bPhieuNhap.SuaPN(pn))
            {
                MessageBox.Show("Sửa phiếu nhập thành công");
                bPhieuNhap.HienThiPN(dgvPhieuNhap);
            }
            else
            {
                MessageBox.Show("Sửa phiếu nhập thất bại");
            }
        }



        // =======================   XÓA   ========================
        private void btXoa_Click_1(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.IDSP = int.Parse(txtIDSP.Text);
            if (bSanPham.XoaSP(sp))
            {
                MessageBox.Show("Xóa sản phẩm thành công");
                bSanPham.HienThiSP(dgvSanPham);
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm thất bại");
            }
        }
        private void btXoaNV_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.IDNV = int.Parse(txtIDNV.Text);
            if (bNhanVien.XoaNV(nv))
            {
                MessageBox.Show("Xóa nhân viên thành công");
                bNhanVien.HienThiNV(dgvNhanVien);
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại");
            }
        }
        private void btXoaAcc_Click(object sender, EventArgs e)
        {
            Account ac = new Account();
            ac.IDAcc = int.Parse(txtIDAcc.Text);
            if (bAccount.XoaAcc(ac))
            {
                MessageBox.Show("Xóa tài khoản thành công");
                bAccount.HienThiAcc(dgvAccount);
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại");
            }
        }
        private void btXoaKH_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.IDKH = int.Parse(txtIDAcc.Text);
            if (bKhachHang.XoaKH(kh))
            {
                MessageBox.Show("Xóa khách hàng thành công");
                bKhachHang.HienThiKH(dgvKhachHang);
            }
            else
            {
                MessageBox.Show("Xóa khách hàng thất bại");
            }
        }
        private void btXoaPN_Click(object sender, EventArgs e)
        {
            PhieuNhap pn = new PhieuNhap();
            pn.IDPN = int.Parse(txtIDPN.Text);
            if (bPhieuNhap.XoaPN(pn))
            {
                MessageBox.Show("Xóa phiếu nhập thành công");
                bPhieuNhap.HienThiPN(dgvPhieuNhap);
            }
            else
            {
                MessageBox.Show("Xóa phiếu nhập thất bại");
            }
        }
        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            int index = dgvHoaDon.CurrentCell.RowIndex;
            hd.IDHD = int.Parse(dgvHoaDon.Rows[index].Cells[0].Value.ToString());
            if(bHoaDon.XoaHD(hd))
            {
                MessageBox.Show("Xóa hóa đơn thành công");
                bHoaDon.HienThiDSHD(dgvHoaDon);
            }    
            else
            {
                MessageBox.Show("Hóa đơn đã xóa rồi!!!");
            }
        }
        // =========   CHI TIẾT PHIẾU NHẬP   =============


        private void dgvPhieuNhap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fChiTietPhieuNhap f = new fChiTietPhieuNhap();
            f.IDPN = int.Parse(dgvPhieuNhap.Rows[e.RowIndex].Cells[0].Value.ToString());
            f.tongtien = double.Parse(dgvPhieuNhap.Rows[e.RowIndex].Cells["TongTien"].Value.ToString());
            f.ShowDialog();
        }
        private void dgvHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fChiTietHoaDon f = new fChiTietHoaDon();
            f.IDHD = int.Parse(dgvHoaDon.Rows[e.RowIndex].Cells["IDHD"].Value.ToString());
            f.ShowDialog();
        }
        // ====================== TÌM KIẾM ========================
        private void btnTimSP_Click(object sender, EventArgs e)
        {
            string ten = cbbTimTenSP.Text;
            bSanPham.TimSP(ten, dgvSanPham);
            cbbTimTenSP.Text = "";
        }

        private void btnTimNV_Click(object sender, EventArgs e)
        {
            string ten = cbbTimTenNV.Text;
            bNhanVien.TimNV(dgvNhanVien, ten);
        }

        private void btnTimACC_Click(object sender, EventArgs e)
        {
            string ten = cbbTimTK.Text;
            bAccount.TimTK(dgvAccount, ten);
        }

        private void btTimKH_Click(object sender, EventArgs e)
        {
            string ten = txtTenKH.Text;
            bKhachHang.TimKH(dgvKhachHang, ten);
        }

        private void btnTimPN_Click(object sender, EventArgs e)
        {
            string ten = cbbTimTenPN.Text;
            bPhieuNhap.TimPN(dgvPhieuNhap, ten);
            cbbTimTenPN.Text = "";
        }

        // ==================Xem danh sách=====================
        private void btnXemPN_Click(object sender, EventArgs e)
        {
            HienThiPhieuNhap();
        }
        private void btnXemHD_Click(object sender, EventArgs e)
        {
            HienThiHoaDon();
        }

        private void btnTimHD_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(cbbTimTeNKHHD.SelectedValue.ToString());
            bHoaDon.TimHD(dgvHoaDon, ma);
            cbbTimTenSP.Text = "";
        }

        
    }
}
