using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTCSDL_QuanLyShop.DAO
{
    class DAO_ThongKe
    {
        MyShopEntities db;
        public DAO_ThongKe()
        {
            db = new MyShopEntities();
        }
        
        public List<obj_BaoCao_LoaiSP> DoanhThuTheoLoaiSP(DateTime ngayBD)
        {
            obj_BaoCao_LoaiSP dmsp; 
            List<obj_BaoCao_LoaiSP> dsbc = new List<obj_BaoCao_LoaiSP>();
            var dm = db.FN_DOANHTHU_THEONHOMHANG(ngayBD, DateTime.Now).ToList();
            foreach (var item in dm)
            {   dmsp = new obj_BaoCao_LoaiSP();
                dmsp.IDDM = item.IDDM;
                dmsp.TenDM = item.TenDM;
                dmsp.ThanhTien = item.THANHTIEN;
                dsbc.Add(dmsp);
            }
            return dsbc;
        }

    }
}
