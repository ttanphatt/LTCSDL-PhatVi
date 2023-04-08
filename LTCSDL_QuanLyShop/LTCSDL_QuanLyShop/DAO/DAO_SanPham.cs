using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTCSDL_QuanLyShop.BUS;

namespace LTCSDL_QuanLyShop.DAO
{
    internal class DAO_SanPham
    {
        MyShopEntities db;

        public DAO_SanPham()
        {
            db = new MyShopEntities();
        }
        public dynamic HienThiSanPham()
        {
            var dsp = db.SanPhams.Select(s => new
            {
                s.IDSP,
                s.TenSP,
                s.SLKho,
                s.MauSac,
                s.XuatXu,
                s.GiaBan
            }).ToList();
            return dsp;
        }
        public void ThemSP(SanPham s)
        {
            db.SanPhams.Add(s);
            db.SaveChanges();
        }
        public bool CheckSuaSP(SanPham sp)
        {
            SanPham s = db.SanPhams.Find(sp.IDSP);
            if (s != null)
            {
                return true;
            }
            else
                return false;
        }
        public void SuaSP(SanPham sp)
        {
            SanPham s = db.SanPhams.Find(sp.IDSP);
            s.IDSP = sp.IDSP;
            s.TenSP = sp.TenSP;
            s.SLKho = sp.SLKho;
            s.MauSac = sp.MauSac;
            s.XuatXu = sp.XuatXu;
            s.GiaBan = sp.GiaBan;
            db.SaveChanges();
        }
        public bool CheckXoaSP(SanPham sp)
        {
            SanPham s = db.SanPhams.Find(sp.IDSP);
            if (sp != null)
            {
                return true;
            }
            else
                return false;
        }
        public void XoaSP(SanPham sp)
        {
            SanPham s = db.SanPhams.Find(sp.IDSP);
            db.SanPhams.Remove(s);
            db.SaveChanges();
        }


        // NHÀ CUNG CẤP
        public dynamic HienThiNhaCungCap()
        {
            var ds = db.NhaCungCaps.Select(s => new
            {
                s.IDNCC,
                s.TenNCC,
                s.SDT,
                s.DiaChi,
            }).ToList();
            return ds;
        }
    }
}
