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
    internal class BUS_Account
    {
        DAO_Account dAccount;
        public BUS_Account()
        {
            dAccount = new DAO_Account();
        }
        public void HienThiAcc(DataGridView dgv)
        {
            dgv.DataSource = dAccount.HienThiAcc();
        }
        public bool ThemAcc(Account a)
        {
            try
            {
                dAccount.ThemAcc(a);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool SuaAcc(Account a)
        {
            if (dAccount.CheckSuaAcc(a))
            {
                try
                {
                    dAccount.SuaAcc(a);
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
        public bool XoaAcc(Account a)
        {
            if (dAccount.CheckXoaAcc(a))
            {
                try
                {
                    dAccount.XoaAcc(a);
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
