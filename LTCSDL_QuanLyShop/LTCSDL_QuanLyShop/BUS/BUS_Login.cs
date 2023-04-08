using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTCSDL_QuanLyShop.DAO;

namespace LTCSDL_QuanLyShop.BUS
{
    public class BUS_Login
    {
        DAO_Login dLogin;
        public BUS_Login()
        {
            dLogin = new DAO_Login();
        }
        public bool Login(string name, string pass)
        {
            if (dLogin.Login(name, pass))
                return true;
            return false;
        }
    }
}
