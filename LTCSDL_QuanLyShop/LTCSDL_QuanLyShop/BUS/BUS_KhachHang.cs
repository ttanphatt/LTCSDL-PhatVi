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
    }
}
