using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTCSDL_QuanLyShop;

namespace LTCSDL_QuanLyShop.DAO
{
    internal class DAO_Account
    {
        MyShopEntities db;
        public DAO_Account()
        {
            db = new MyShopEntities();
        }
        public dynamic HienThiAcc()
        {
            var ds = db.Accounts.Select(s => new
            {
                s.IDAcc,
                s.TenTK,
                s.PassTK,
            }).ToList();
            return ds;
        }
        public void ThemAcc(Account a)
        {
            db.Accounts.Add(a);
            db.SaveChanges();
        }
        public bool CheckSuaAcc(Account ac)
        {
            Account a = db.Accounts.Find(ac.IDAcc);
            if (a != null)
            {
                return true;
            }
            else
                return false;
        }
        public void SuaAcc(Account ac)
        {
            Account a = db.Accounts.Find(ac.IDAcc);
            a.IDAcc = a.IDAcc;
            a.TenTK = a.TenTK;
            a.PassTK = a.PassTK;
            
            db.SaveChanges();
        }
        public bool CheckXoaAcc(Account ac)
        {
            Account a = db.Accounts.Find(ac.IDAcc);
            if (ac != null)
            {
                return true;
            }
            else
                return false;
        }
        public void XoaAcc(Account ac)
        {
            Account a = db.Accounts.Find(ac.IDAcc);
            db.Accounts.Remove(a);
            db.SaveChanges();
        }
    }
}
