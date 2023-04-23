using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTCSDL_QuanLyShop.BUS;

namespace LTCSDL_QuanLyShop.DAO
{
    internal class DAO_NhanVien
    {
        MyShopEntities db;
        public DAO_NhanVien()
        {
            db = new MyShopEntities();
        }
        public dynamic HienThiNhanVien()
        {
            var ds = db.NhanViens.Select(s => new
            {
                s.IDNV,
                s.TenNV,
                s.SDT,
                s.Luong,
            }).ToList();
            return ds;
        }
        public NhanVien HienThiNVTheoID(int IDAcc)
        {
            NhanVien nv = db.NhanViens.Where(s => s.IDAcc == IDAcc).FirstOrDefault();
            return nv;
        }
        public void ThemNV(NhanVien s)
        {
            db.NhanViens.Add(s);
            db.SaveChanges();
        }
        public bool CheckSuaNV(NhanVien nv)
        {
            NhanVien s = db.NhanViens.Find(nv.IDNV);
            if (s != null)
            {
                return true;
            }
            else
                return false;
        }
        public void SuaNV(NhanVien nv)
        {
            NhanVien s = db.NhanViens.Find(nv.IDNV);
            s.IDNV = nv.IDNV;
            s.TenNV = nv.TenNV;
            s.SDT = nv.SDT;
            s.Luong= nv.Luong;
            db.SaveChanges();
        }
        public bool CheckXoaNV(NhanVien nv)
        {
            NhanVien s = db.NhanViens.Find(nv.IDNV);
            if (nv != null)
            {
                return true;
            }
            else
                return false;
        }
        public void XoaNV(NhanVien nv)
        {
            NhanVien s = db.NhanViens.Find(nv.IDNV);
            db.NhanViens.Remove(s);
            db.SaveChanges();
        }

        public dynamic TimNV(string ten)
        {
            var ds = db.NhanViens.Where(s => s.TenNV.Contains(ten)).
                Select(s => new
                {
                    s.IDNV,
                    s.TenNV,
                    s.SDT,
                    s.Luong,
                }).ToList();
            return ds;
        }
    }
   
}
