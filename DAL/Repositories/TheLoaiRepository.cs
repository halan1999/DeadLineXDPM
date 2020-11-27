using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.CodeFirst;


namespace DAL.Repositories
{
    public class TheLoaiRepository : IDisposable
    {
        private DataContext context = new DataContext();

        private bool disposedValue = false;


        public List<TheLoai> getTheLoais()
        {
            return context.theloais.ToList();
        }
        public void Save(TheLoai t)
        {
            context.theloais.Add(t);
            context.SaveChanges();
        }
        public int Delete(int idxoa)
        {
            var d = new TheLoai();
            d = context.theloais.First(x => x.id_TheLoai == idxoa);
            context.theloais.Remove(d);
            return context.SaveChanges();
        }
        public TheLoai Find(int id)
        {
            TheLoai tl = context.theloais.First(p => p.id_TheLoai == id);
            if(tl != null)
            {
                return tl;
            }
            return null;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing && context != null)
                {
                    context.Dispose();
                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
