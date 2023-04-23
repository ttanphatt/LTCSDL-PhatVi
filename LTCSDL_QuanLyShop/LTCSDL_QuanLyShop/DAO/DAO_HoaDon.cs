using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTCSDL_QuanLyShop.DAO
{
    class DAO_HoaDon
    {
        MyShopEntities db;
        public DAO_HoaDon()
        {
            db = new MyShopEntities();
        }
        public void CatNhatHD(HoaDon h)
        {
            HoaDon hd = db.HoaDons.Find(h.IDHD);
            hd.IDHD = h.IDHD;
            hd.NgayLap = h.NgayLap;
            hd.TongTien = h.TongTien;
            hd.IDKH = h.IDKH;
            db.SaveChanges();
        }
        public void ThemHD(HoaDon h)
        {
            db.HoaDons.Add(h);
            db.SaveChanges();
        }

        public dynamic HienThiDSHD()
        {
            var ds = db.HoaDons.Select(s => new
            {
                s.IDHD,
                s.KhachHang.TenKH,
                s.NgayLap,
                s.TongTien,
            }).ToList();
            return ds;
        }
        public HoaDon HienThiHDTheoID(int maHD)
        {
            HoaDon hd = db.HoaDons.Where(s => s.IDHD == maHD).FirstOrDefault();
            return hd;
        }
        public dynamic TimHD(int ma)
        {
            var ds = db.HoaDons.Where(s => s.IDKH == ma).
                Select(s => new
                {
                    s.IDHD,
                    s.KhachHang.TenKH,
                    s.NgayLap,
                    s.TongTien,
                    s.IDKH
                }).ToList();
            return ds;
        }
        public bool CheckHD(HoaDon h)
        {
            HoaDon hd = db.HoaDons.Find(h.IDHD);
            if (h != null)
                return true;
            return false;
        }
        public void XoaHD(HoaDon h)
        {
            HoaDon hd = db.HoaDons.Find(h.IDHD);
            db.HoaDons.Remove(hd);
            db.SaveChanges();
        }
        // =============Chi Tiet Phieu Nhap===============
        public dynamic HienThiDSCTHD(int maHD)
        {
            var ds = db.ChiTietHoaDons.Where(s => s.IDHD == maHD).
                Select(s => new
                {
                    s.IDCTHD,
                    s.SanPham.TenSP,
                    s.SoLuong,
                    s.DonGia
                }).ToList();
            return ds;
        }
        public ChiTietHoaDon HienThiThongTinCTHD(int maCTHD)
        {
            ChiTietHoaDon ct = db.ChiTietHoaDons.Where(s => s.IDCTHD == maCTHD).FirstOrDefault();
            return ct;
        }
        public bool CheckCTHD(int ma)
        {
            ChiTietHoaDon ct = db.ChiTietHoaDons.Find(ma);
            if (ct != null)
                return true;
            return false;
        }
        public void ThemCTHD(ChiTietHoaDon c)
        {
            db.ChiTietHoaDons.Add(c);
            db.SaveChanges();
        }

        public void XoaCTHD(int ma)
        {
            ChiTietHoaDon ct = db.ChiTietHoaDons.Find(ma);
            db.ChiTietHoaDons.Remove(ct);
            db.SaveChanges();
        }
        public void CatNhatCTHD(ChiTietHoaDon c)
        {
            ChiTietHoaDon ct = db.ChiTietHoaDons.Find(c.IDCTHD);
            ct.IDCTHD = c.IDCTHD;
            ct.SoLuong = c.SoLuong;
            ct.DonGia = c.DonGia;
            ct.IDSP = c.IDSP;
            ct.IDHD = c.IDHD;
            db.SaveChanges();
        }
    }
}
