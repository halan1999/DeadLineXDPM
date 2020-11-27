using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BULL;
using XayDungPhanMem;


namespace XayDungPhanMem
{
    public partial class ThemDVD : Form
    {
        DVDBUL dvdbul;
        TieuDeBUL tdbul; 

        
        public ThemDVD()
        {
            dvdbul = new DVDBUL();
            tdbul = new TieuDeBUL();
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtSL.Text != "")
            {
                List<eTieuDe> list = new List<eTieuDe>();
                list = tdbul.getTieuDes();
               
                eTieuDe etd = new eTieuDe();
                etd = list.FirstOrDefault(a => a.tenTieuDe == cbbTieuDe.Text);
                eDVD dVD = new eDVD();
                dVD.id_TieuDe = etd.id_TieuDe;
                dVD.trangThai = 1;
                dvdbul.Save(dVD);
                MessageBox.Show("Them Thanh Cong");
            }
            else
            {
                MessageBox.Show("Vui long nhap so luong");
            }
            
           
        }

        public void ThemDVD_Load(object sender, EventArgs e)
        {
            List<eTieuDe> list = new List<eTieuDe>();
            list = tdbul.getTieuDes();
            List<String> lt = new List<string>();
           foreach(var item in list)
            {
                lt.Add(item.tenTieuDe);
            }
            cbbTieuDe.DataSource = lt;
        }

        public void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void ThemDVD_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc muốn thoát ?", "My Application",
            MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
