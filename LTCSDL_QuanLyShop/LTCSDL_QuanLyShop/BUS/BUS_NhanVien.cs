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
    internal class BUS_NhanVien
    {
        DAO_NhanVien dNhanVien;
        public BUS_NhanVien()
        {
            dNhanVien = new DAO_NhanVien();
        }
        public void HienThiNV(DataGridView dgv)
        {
            dgv.DataSource = dNhanVien.HienThiNhanVien();
        }
        public NhanVien HienThiNVTheoMa(int IDAcc)
        {
             return dNhanVien.HienThiNVTheoID(IDAcc);
        }
        public void HienThicbbNV(ComboBox cb)
        {
            cb.DataSource = dNhanVien.HienThiNhanVien();
            cb.DisplayMember = "TenNV";
            cb.ValueMember = "IDNV";
        }
        public bool ThemNV(NhanVien s)
        {
            try
            {
                dNhanVien.ThemNV(s);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool SuaNV(NhanVien nv)
        {
            if (dNhanVien.CheckSuaNV(nv))
            {
                try
                {
                    dNhanVien.SuaNV(nv);
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
        public bool XoaNV(NhanVien nv)
        {
            if (dNhanVien.CheckXoaNV(nv))
            {
                try
                {
                    dNhanVien.XoaNV(nv);
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

        public void TimNV(DataGridView dgv, string ten)
        {
            if (dNhanVien.TimNV(ten).Count != 0)
            {
                MessageBox.Show("Tìm tên thành công");
                dgv.DataSource = dNhanVien.TimNV(ten);
            }
            else
                MessageBox.Show("Tên này không tồn tại");
                
        }
    }
    
}
