using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.CodeFirst;
using System.Data.Entity;


namespace DAL.Repositories
{
    public class TieuDeRepositories : IDisposable
    {
        DataContext context = new DataContext();
        private bool disposedValue = false;

        public List<TieuDe> getTieuDes()
        {

            return context.tieudes.ToList();
        }
        public int Save(TieuDe t)
        {
            context.tieudes.Add(t);
            return context.SaveChanges();
        }
        public int Delete(int idxoa)
        {
            var p = new TieuDe();
            p = context.tieudes.First(x => x.id_TieuDe.Equals(idxoa));
            context.tieudes.Remove(p);
            return context.SaveChanges();
        }
        public TieuDe Find(int id)
        {
            return context.tieudes.First(p => p.id_TieuDe == id);
        }
        public TheLoai FindTheLoaiById(int id)
        {
            TheLoai tl = context.theloais.First(p => p.id_TheLoai == id);
            if (tl != null)
            {
                return tl; ;
            }
            return null;
        }

        public List<PhieuDatTruoc> FindPhieuDatTruocByidTieuDe(int id)
        {

            List<PhieuDatTruoc> lst = new List<PhieuDatTruoc>();
            List<PhieuDatTruoc> lstafter = new List<PhieuDatTruoc>();
            foreach(var item in lst)
            {
                if (item.id_TieuDe == id)
                {
                    lstafter.Add(item);
                }

            }
            return lstafter;
        }
        public PhieuDatTruoc FindbyID(int id)
        {
            TieuDe c = context.tieudes.First(p => p.id_TieuDe == id);
            PhieuDatTruoc td = new PhieuDatTruoc();
            if (td.id_TieuDe==c.id_TieuDe)
            {
                return td;
            }
            return null;
        }
        public void Dispose()
        {
            Dispose(true);
            
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
                if (disposing && context != null)
                {
                    context.Dispose();
                }
                disposedValue = true;
        }
    }
      
}

