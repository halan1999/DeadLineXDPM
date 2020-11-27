using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XayDungPhanMem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void quanlidia_click(object sender, EventArgs e)
        {
            frmQuanlydia quanLyDia = new frmQuanlydia();
            quanLyDia.Show();
        }

        private void DatTruoc(object sender, EventArgs e)
        {
            frmDatTruoc f = new frmDatTruoc();
            f.ShowDialog();
        }
    }
}
