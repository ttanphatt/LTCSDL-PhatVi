using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LTCSDL_QuanLyShop.BUS;

namespace LTCSDL_QuanLyShop
{
    public partial class fThongTinHoaDon : Form
    {
        public int IDHD;
        BUS_HoaDon bHoaDon;
        public fThongTinHoaDon()
        {
            InitializeComponent();
        }

        private void fThongTinHoaDon_Load(object sender, EventArgs e)
        {
            lbIDHD.Text = IDHD.ToString();
            
        }

        private void lbIDHD_Click(object sender, EventArgs e)
        {

        }

        private void lbTenKH_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbSDT_Click(object sender, EventArgs e)
        {

        }

        private void lbTongTien_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
