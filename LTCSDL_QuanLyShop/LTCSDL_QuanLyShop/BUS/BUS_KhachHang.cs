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
    internal class BUS_KhachHang
    {
        DAO_KhachHang dKhachHang;
        public BUS_KhachHang()
        {
            dKhachHang = new DAO_KhachHang();
        }
        public void HienThiKH(DataGridView dgv)
        {
            dgv.DataSource = dKhachHang.HienThiKH();
        }
        public void HienThicbbKH(ComboBox cbb)
        {
            cbb.DataSource = dKhachHang.HienThiKH();
            cbb.DisplayMember = "TenKH";
            cbb.ValueMember = "IDKH";
        }
        public KhachHang HienTTKHTheoMa(int maKH)
        {
            return dKhachHang.HienThiThongTinKHTheoMa(maKH);
        }
        public bool ThemKH(KhachHang k)
        {
            try
            {
                dKhachHang.ThemKH(k);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool SuaKH(KhachHang k)
        {
            if (dKhachHang.CheckSuaKH(k))
            {
                try
                {
                    dKhachHang.SuaKH(k);
                    return true;

                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool XoaKH(KhachHang k)
        {
            if (dKhachHang.CheckXoaKH(k))
            {
                try
                {
                    dKhachHang.XoaKH(k);
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

        public void TimKH(DataGridView dgv, string ten)
        {
            if (dKhachHang.TimKH(ten).Count != 0)
            {
                MessageBox.Show("Tìm thành công");
                dgv.DataSource = dKhachHang.TimKH(ten);
            }
            else
                MessageBox.Show("Không có tên trong danh sách");
        }
    }
}
