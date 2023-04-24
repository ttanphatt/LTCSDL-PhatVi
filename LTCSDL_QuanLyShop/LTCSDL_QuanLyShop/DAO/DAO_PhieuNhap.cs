using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTCSDL_QuanLyShop;

namespace LTCSDL_QuanLyShop.DAO
{
    internal class DAO_PhieuNhap
    {
        MyShopEntities db;
        public DAO_PhieuNhap()
        {
            db = new MyShopEntities();
        }
        public dynamic HienThiPN()
        {
            var ds = db.PhieuNhaps.Select(s => new
            {
                s.IDPN,
                s.TenPN,
                s.NgayNhap,
                s.NhaCungCap.TenNCC,
                s.NhanVien.TenNV,
                s.TongTien,

            }).ToList();
            return ds;
        }
        public PhieuNhap HienThiPN(int IDPN)
        {
            PhieuNhap ds = db.PhieuNhaps.Where(s => s.IDPN == IDPN).FirstOrDefault();
            return ds;
        }
        public void ThemPN(PhieuNhap p)
        {
            db.PhieuNhaps.Add(p);
            db.SaveChanges();
        }
        public bool CheckSuaPN(PhieuNhap p)
        {
            PhieuNhap pn = db.PhieuNhaps.Find(p.IDPN);
            if (pn != null)
            {
                return true;
            }
            else
                return false;
        }
        public void SuaPN(PhieuNhap p)
        {
            PhieuNhap pn = db.PhieuNhaps.Find(p.IDPN);
            pn.IDPN = p.IDPN;
            pn.TenPN = p.TenPN;
            pn.NgayNhap = p.NgayNhap;
            pn.IDNCC = p.IDNCC;
            pn.IDNV = p.IDNV;
            pn.TongTien = p.TongTien;
            db.SaveChanges();
        }
        public bool CheckXoaPN(PhieuNhap p)
        {
            PhieuNhap pn = db.PhieuNhaps.Find(p.IDPN);
            if (pn != null)
            {
                return true;
            }
            else
                return false;
        }
        public void XoaPN(PhieuNhap p)
        {
            PhieuNhap pn = db.PhieuNhaps.Find(p.IDPN);
            db.PhieuNhaps.Remove(pn);
            db.SaveChanges();
        }

        public dynamic TimPN(string ten)
        {
            var ds = db.PhieuNhaps.Where(s => s.TenPN.Contains(ten)).
                Select(s => new
                {
                    s.IDPN,
                    s.TenPN,
                    s.NgayNhap,
                    s.TongTien,
                    s.NhaCungCap.TenNCC,
                    s.NhanVien.TenNV
                }).ToList();
            return ds;
        }

        //  ============ CHI TIẾT PHIẾU NHẬP  ==============
        public dynamic HienThiChiTietPhieuNhap(int IDPN)
        {
            var ds = db.ChiTietPNs.Where(s=> s.IDPN == IDPN).Select(s => new
            {
                s.IDCTPN,
                s.PhieuNhap.IDPN,
                s.SanPham.TenSP,
                s.SoLuong,
                s.DonGia,
            }).ToList();
            return ds;
        }
        public List<ChiTietPN> HienThiCTPNTheoID(int ma)
        {
            return db.ChiTietPNs.Where(s => s.IDCTPN == ma).ToList();
        }
        public void ThemCTPN(ChiTietPN c)
        {
            db.ChiTietPNs.Add(c);
            db.SaveChanges();
        }
        public void XoaCTPN(ChiTietPN c)
        {
            ChiTietPN ct = db.ChiTietPNs.Find(c.IDCTPN);
            db.ChiTietPNs.Remove(ct);
            db.SaveChanges();
        }


        public bool CheckCTPN(ChiTietPN c)
        {
            ChiTietPN ct = db.ChiTietPNs.Find(c.IDCTPN);
            if(ct != null)
            {
                return true;
            }
            return false;
        }
        public ChiTietPN LayCTPN(int ma)
        {
            ChiTietPN ct = db.ChiTietPNs.Where(s => s.IDCTPN == ma).FirstOrDefault();
            return ct;
        }
        public void CatNhatCTPN(ChiTietPN p)
        {
            ChiTietPN ctpn = db.ChiTietPNs.Find(p.IDCTPN);
            ctpn.IDCTPN = p.IDCTPN;
            ctpn.IDSP = p.IDSP;
            ctpn.SoLuong = p.SoLuong;
            ctpn.DonGia = p.DonGia;
            db.SaveChanges();
        }
    }
}
