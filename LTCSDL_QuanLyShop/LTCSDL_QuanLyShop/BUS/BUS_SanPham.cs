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
        //---------- Danh Muc --------
        public void HienThicbbDM(ComboBox cbb)
        {
            cbb.DataSource = dSanPham.HienThiDM();
            cbb.DisplayMember = "TenDM";
            cbb.ValueMember = "IDDM";
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
        public List<SanPham> HienThiSPTXT(string ten)
        {
            return dSanPham.HienThitxtSP(ten);
        }
        public void HienThitxtSP(string ten)
        {
            dSanPham.HienThitxtSP(ten);
        }
        public SanPham HienThiSPTheoMa(int maSP)
        {
            return dSanPham.HienThiSPTheoMa(maSP);
            
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

        public void TimSP(string ten, DataGridView dgv)
        {
            if(dSanPham.TimSP(ten).Count != 0)
            {
                MessageBox.Show("Tìm sản phẩm thành công");
                dgv.DataSource = dSanPham.TimSP(ten);
            }
            else
            {
                MessageBox.Show("Tìm sản phẩm thất bại");
            }    
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
