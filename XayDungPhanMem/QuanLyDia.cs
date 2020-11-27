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
using Entity;

namespace XayDungPhanMem
{
    public partial class frmQuanlydia : Form
    {
        TieuDeBUL tieuDeBUL;
        DVDBUL dVDBUL;
        TheLoaiBUL theLoaiBUL;
        private BindingSource binding = new BindingSource();
        public frmQuanlydia()
        {
            dVDBUL = new DVDBUL();
            tieuDeBUL = new TieuDeBUL();
            theLoaiBUL = new TheLoaiBUL();
            InitializeComponent();
            dgv_dsdia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void Clearr()
        {
            txtgiathue.Text = "";
            txttgthue.Text = "";
            txt_iddia.Text = "";
            txt_tendia.Text = "";
            txt_tragthai.Text = "";
        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            Clearr();
            if(nhapid.Text != "")
            {
                int id = Convert.ToInt32(nhapid.Text);
                eDVD dvd = dVDBUL.FindDVDById(id);
                if(dvd != null)
                {
                    eTieuDe tieuDe = tieuDe = tieuDeBUL.Find(dvd.id_TieuDe);
                    eTheLoai theLoai = tieuDeBUL.FindTheLoaiById(tieuDe.id_TieuDe);
                    txt_tendia.Text = tieuDe.tenTieuDe;
                    txtgiathue.Text = theLoai.giaThue.ToString();
                    txttgthue.Text = theLoai.thoiGianThue.ToString();
                    txt_iddia.Text = dvd.id_DVD.ToString();
                    txt_tragthai.Text = dvd.trangThai.ToString();
                    btn_timkiem.Text = " Tìm kiếm";
                }
                else
                {
                    MessageBox.Show("Không có đĩa trong danh sách");
                }
            }
            else
            {
                MessageBox.Show("Nhap ma can tim");
            }
            
            
        }

        public void btn_them_Click(object sender, EventArgs e)
        {
            ThemDVD them = new ThemDVD();
            them.ShowDialog();
            //List<eDVD> lst = new List<eDVD>();
            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(dgv_dsdia.SelectedRows.Count >0)
            {
                int id = Convert.ToInt32(txt_iddia.Text);
                dVDBUL.DeleteDVD(id);
                LoadData();
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đĩa bạn muốn xóa");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void dgv_dsdia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuanLyDia_Load(object sender, EventArgs e)
        {
            dgv_dsdia.DataSource = dVDBUL.getDVDs();

        }
        public void LoadData()
        {
            List<eDVD> list =  dVDBUL.getDVDs();
            dgv_dsdia.DataSource = list;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void clickDGVDia(object sender, EventArgs e)
        {

        }

        private void dgv_dsdia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgv_dsdia.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txt_iddia.Text = row.Cells[0].Value.ToString();
                txt_tragthai.Text = row.Cells[2].Value.ToString();

                int s = Convert.ToInt32(row.Cells[2].Value.ToString());
                eTieuDe tieuDe = new eTieuDe();
                eTheLoai theLoai = new eTheLoai();
                tieuDe = tieuDeBUL.Find(s);
                theLoai = theLoaiBUL.FindDVDById(tieuDe.id_TieuDe);
                txt_tendia.Text = tieuDe.tenTieuDe;
                txtgiathue.Text = theLoai.giaThue.ToString();
                txttgthue.Text = theLoai.thoiGianThue.ToString();
              
                //Không cho phép sửa trường STT
                ///txtSTT.Enabled = false;
            }
        }

        private void frmQuanlydia_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát ?", "My Application",
            MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;

        }
    }
}
