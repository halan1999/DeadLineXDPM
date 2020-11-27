using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BULL;
using System.Data.Entity;

namespace XayDungPhanMem
{
    public partial class QuanLyKhachHang : Form
    {
        KhachHangBUL kh;
        public QuanLyKhachHang()
        {
            kh = new KhachHangBUL();
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            dgv_dskh.DataSource = kh.getKhachHangs1();

        }
    }
}
