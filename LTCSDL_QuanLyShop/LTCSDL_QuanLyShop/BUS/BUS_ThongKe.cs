using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTCSDL_QuanLyShop.DAO;

namespace LTCSDL_QuanLyShop.BUS
{
    class BUS_ThongKe
    {
        DAO_ThongKe dThongKe;
        public BUS_ThongKe()
        {
            dThongKe = new DAO_ThongKe();
        }
        public List<obj_BaoCao_LoaiSP> DoanhThuTheoLoaiSP(DateTime ngayBD)
        {
            return dThongKe.DoanhThuTheoLoaiSP(ngayBD);
        }
    }
}
