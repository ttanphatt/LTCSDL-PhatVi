using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTCSDL_QuanLyShop.DAO
{
    public class DAO_Login
    {
        MyShopEntities db;
        public DAO_Login()
        {
            db = new MyShopEntities();
        }
        public bool Login(string name, string pass)
        {
            int? dn;
            dn = db.SP_GetAccountByUsername(name, pass).FirstOrDefault();
            if (dn == 1)
                return true;
            return false;
        }
    }
}
