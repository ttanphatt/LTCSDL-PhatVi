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
    internal class BUS_PhieuNhap
    {
        DAO_PhieuNhap dPhieuNhap;
        public int IDPN;
        public BUS_PhieuNhap()
        {
            dPhieuNhap = new DAO_PhieuNhap();
        }
        public void HienThiPN(DataGridView dgv)
        {
            dgv.DataSource = dPhieuNhap.HienThiPN();
        }
        public PhieuNhap HienThiPNtheoID( int IDPN)
        {
           return dPhieuNhap.HienThiPN(IDPN);
        }
        public bool ThemPN(PhieuNhap p)
        {
            try
            {
                dPhieuNhap.ThemPN(p);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool SuaPN(PhieuNhap p )
        {
            if (dPhieuNhap.CheckSuaPN(p))
            {
                try
                {
                    dPhieuNhap.SuaPN(p);
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
        public bool XoaPN(PhieuNhap p)
        {
            if (dPhieuNhap.CheckXoaPN(p))
            {
                try
                {
                    dPhieuNhap.XoaPN(p);
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


        //  ============= CHI TIẾT PHIẾU NHẬP  ===========
        public void HienThiChiTietPhieuNhap(DataGridView dgv, int IDPN)
        {
            dgv.DataSource = dPhieuNhap.HienThiChiTietPhieuNhap(IDPN);
        }
        public bool ThemCTPN(ChiTietPN c)
        {
            try
            {
                dPhieuNhap.ThemCTPN(c);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
    }
}
