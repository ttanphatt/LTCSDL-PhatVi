using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTCSDL_QuanLyShop;

namespace LTCSDL_QuanLyShop.DAO
{
    internal class DAO_KhachHang
    {
        MyShopEntities db;
        public DAO_KhachHang()
        {
            db = new MyShopEntities();
        }
        public dynamic HienThiKH()
        {
            var ds = db.KhachHangs.Select(s => new
            {
                s.IDKH,
                s.TenKH,
                s.SDT,
            }).ToList();
            return ds;
        }
        public void ThemKH(KhachHang k)
        {
            db.KhachHangs.Add(k);
            db.SaveChanges();
        }
        public bool CheckSuaKH(KhachHang k)
        {
            KhachHang kh = db.KhachHangs.Find(k.IDKH);
            if (kh != null)
            {
                return true;
            }
            else
                return false;
        }
        public void SuaKH(KhachHang k)
        {
            KhachHang kh = db.KhachHangs.Find(k.IDKH);
            kh.IDKH = k.IDKH;
            kh.TenKH = k.TenKH;
            kh.SDT = k.SDT;
            db.SaveChanges();
        }
        public bool CheckXoaKH(KhachHang k)
        {
            KhachHang kh = db.KhachHangs.Find(k.IDKH);
            if (kh != null)
            {
                return true;
            }
            else
                return false;
        }
        public void XoaKH(KhachHang k)
        {
            KhachHang kh = db.KhachHangs.Find(k.IDKH);
            db.KhachHangs.Remove(kh);
            db.SaveChanges();
        }
    }
}
