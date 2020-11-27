using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.CodeFirst;
using DAL.Repositories;
using System.Data.Entity;
using Entity;

namespace BULL
{
    public class TieuDeBUL
    {
        TieuDeRepositories tddal;
        public TieuDeBUL()
        {
            tddal = new TieuDeRepositories();
        }
        public List<eTieuDe> getTieuDes()
        {
            List<eTieuDe> list = new List<eTieuDe>();
            foreach (var item in tddal.getTieuDes())
            {
                eTieuDe tam = new eTieuDe();
                tam.id_TieuDe = item.id_TieuDe;
                tam.tenTieuDe = item.tenTieuDe;
                tam.id_TheLoai = item.id_TheLoai;
                list.Add(tam);
            }
            return list;
        }
        public int Save(eTieuDe d)
        {
            TieuDe item = new TieuDe();
            item.id_TieuDe = d.id_TieuDe;
            item.tenTieuDe = d.tenTieuDe;
            item.id_TheLoai = d.id_TheLoai;


            tddal.Save(item);
            return 1;
        }
        public eTheLoai FindTheLoaiById(int id)
        {
            TheLoai t = tddal.FindTheLoaiById(id);
            if (t != null)
            {
                eTheLoai e = new eTheLoai();

                e.id_TheLoai = t.id_TheLoai;
                e.tenTheLoai = t.tenTheLoai;
                e.giaThue = t.giaThue;
                e.thoiGianThue = t.thoiGianThue;
                return e;
            }
            return null;
            
        }
        public int Delete(int idxoa)
        {
            tddal.Delete(idxoa);
            return 1;
        }
        public eTieuDe Find(int id)
        {
            TieuDe t = tddal.Find(id);
            eTieuDe e = new eTieuDe();

            e.id_TieuDe = t.id_TieuDe;
            e.tenTieuDe = t.tenTieuDe;
            e.id_TheLoai = t.id_TheLoai;
            return e;
        }
        public List<ePhieuDatTruoc> FindPhieuDatTruocByidTieuDe(int id)
        {

            List<PhieuDatTruoc> lst = tddal.FindPhieuDatTruocByidTieuDe(id);
            List<ePhieuDatTruoc> lit = new List<ePhieuDatTruoc>();
            foreach (var item in lst)
            {
               
                    ePhieuDatTruoc e = new ePhieuDatTruoc();
                    e.id_DVD = item.id_DVD;
                    e.id_TieuDe = item.id_TieuDe;
                    e.id_PhieuDatTruoc = item.id_PhieuDatTruoc;
                    e.id_KhachHang = item.id_KhachHang;
                    e.ngayDatTruoc = item.ngayDatTruoc;
                lit.Add(e);      
            }
            return lit;
        }
        public ePhieuDatTruoc FindbyID(int id)
        {
            PhieuDatTruoc p = tddal.FindbyID(id);
            ePhieuDatTruoc tam = new ePhieuDatTruoc();
            tam.id_DVD = p.id_DVD;
            tam.id_TieuDe = p.id_TieuDe;
            tam.id_PhieuDatTruoc = p.id_PhieuDatTruoc;
            tam.id_KhachHang = p.id_KhachHang;
            tam.ngayDatTruoc = p.ngayDatTruoc;
            return tam;

        }

    }
}
