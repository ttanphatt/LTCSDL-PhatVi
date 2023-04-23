using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LTCSDL_QuanLyShop.DAO;

namespace LTCSDL_QuanLyShop.BUS
{
    class BUS_HoaDon
    {
        DAO_HoaDon dHoaDon;
        public BUS_HoaDon()
        {
            dHoaDon = new DAO_HoaDon();
        }
        public HoaDon HienThiHDTheoMa(int maHD)
        {
            return dHoaDon.HienThiHDTheoID(maHD);
        }
        public bool CapNhatHD(HoaDon h)
        {
            if (dHoaDon.CheckHD(h))
            {
                try
                {
                    dHoaDon.CatNhatHD(h);
                    return true;
                }
                catch (DbUpdateException e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
            else
                return false;
        }
        public bool ThemHD(HoaDon h) {
            try
            {
                dHoaDon.ThemHD(h);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
        }
        public void HienThiDSHD(DataGridView dgv)
        {
            dgv.DataSource = dHoaDon.HienThiDSHD();
        }
        
        public void TimHD(DataGridView dgv, int ma)
        {
            if (dHoaDon.TimHD(ma).Count != 0)
            {
                MessageBox.Show("Tìm thành công");
                dgv.DataSource = dHoaDon.TimHD(ma);
            }
            else
                MessageBox.Show("Không có khách hàng");

        }
        public bool XoaHD(HoaDon h)
        {
            if (dHoaDon.CheckHD(h))
            {
                try
                {
                    dHoaDon.XoaHD(h);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
                return false;
        }
        // =============== Chi tiet phieu nhap =================
        public void HienThiDSCTHD(DataGridView dgv, int maHD)
        {
            dgv.DataSource = dHoaDon.HienThiDSCTHD(maHD);
        }
        public ChiTietHoaDon HienThiCTHDTheoMa(int maCTHD)
        {
            return dHoaDon.HienThiThongTinCTHD(maCTHD);
        }
        public bool ThemCTHD(ChiTietHoaDon ct)
        {
            try
            {
                dHoaDon.ThemCTHD(ct);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool XoaCTHD(int ma)
        {
            if (dHoaDon.CheckCTHD(ma))
            {
                try
                {
                    dHoaDon.XoaCTHD(ma);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
                return false;
        }
        public bool CatNhatCTHD(ChiTietHoaDon c)
        {
            if (dHoaDon.CheckCTHD(c.IDCTHD))
            {
                try
                {
                    dHoaDon.CatNhatCTHD(c);
                    return true;
                }
                catch (DbUpdateException e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
            else
                return false;
        }
    }
}
