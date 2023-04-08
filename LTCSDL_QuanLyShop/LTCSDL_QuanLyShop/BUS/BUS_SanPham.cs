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
    internal class BUS_SanPham
    {
        DAO_SanPham dSanPham;

        public BUS_SanPham()
        {
            dSanPham = new DAO_SanPham();
        }
        
        public void HienThiSP(DataGridView dgv)
        {
            dgv.DataSource = dSanPham.HienThiSanPham();
        }
        public void HienThicbbSP(ComboBox cbb)
        {
            cbb.DataSource = dSanPham.HienThiSanPham();
            cbb.DisplayMember = "TenSP";
            cbb.ValueMember = "IDSP";
        }
        public bool ThemSP(SanPham s)
        {
            try
            {
                dSanPham.ThemSP(s);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        public bool SuaSP(SanPham sp)
        {
            if (dSanPham.CheckSuaSP(sp))
            {
                try
                {
                    dSanPham.SuaSP(sp);
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
        public bool XoaSP(SanPham sp)
        {
            if (dSanPham.CheckXoaSP(sp))
            {
                try
                {
                    dSanPham.XoaSP(sp);
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

        //    NHÀ CUNG CẤP
       
        public void HienThicbbNCC(ComboBox cb)
        {
            cb.DataSource = dSanPham.HienThiNhaCungCap();
            cb.DisplayMember = "TenNCC";
            cb.ValueMember = "IDNCC";
        }
    }
}
