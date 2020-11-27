using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;
using DAL.CodeFirst;
using Entity;

namespace BULL
{
    public class TheLoaiBUL
    {
        TheLoaiRepository tldal;
        public TheLoaiBUL()
        {
            tldal = new TheLoaiRepository();
        }
        public List<eTheLoai> getTheLoais()
        {
            List<eTheLoai> list = new List<eTheLoai>();
            foreach (var item in tldal.getTheLoais())
            {
                eTheLoai tam = new eTheLoai();
                tam.id_TheLoai = item.id_TheLoai;
                tam.tenTheLoai= item.tenTheLoai;
                tam.giaThue = item.giaThue;
                tam.thoiGianThue = item.thoiGianThue;
                list.Add(tam);
            }
            return list;
        }
        public void Save(eTheLoai d)
        {
            TheLoai item = new TheLoai();
            item.id_TheLoai = d.id_TheLoai;
            item.tenTheLoai = d.tenTheLoai;
            item.giaThue = d.giaThue;
            item.thoiGianThue = d.thoiGianThue;

            tldal.Save(item);
        }
        public int Delete(int idxoa)
        {
            tldal.Delete(idxoa);
            return 1;
        }

        public eTheLoai FindDVDById(int id)
        {
            TheLoai t =  tldal.Find(id);
            eTheLoai e = new eTheLoai();

            e.id_TheLoai = t.id_TheLoai;
            e.tenTheLoai = t.tenTheLoai;
            e.giaThue = t.giaThue;
            e.thoiGianThue = t.thoiGianThue;
            return e;

        }
    }
}
