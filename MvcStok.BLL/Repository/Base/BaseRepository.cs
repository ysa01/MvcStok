using MvcStok.DAL;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MvcStok.BLL.Repository.Base
{
    public class BaseRepository<T> where T : class
    {
        private MvcDbStokEntities db;
        protected DbSet<T> table;
        public BaseRepository()
        {
            db = new MvcDbStokEntities();
            table = db.Set<T>();
        }
        public int Save()
        {
            return db.SaveChanges();
        }
        public virtual void Insert(T entity)
        {
            table.Add(entity);
            Save();

        }
        public List<T> GetAll()
        {
            return table.ToList();
        }
        public T Find(long ID)
        {
            return table.Find(ID);
        }
        public T Delete(T ID)
        {
            return table.Remove(ID);
        }
       //public T where(long categoryId)
       // {
       //     var cat = table.Where(x => x == categoryId).ToList();
       //     return   cat;
       // }
    }
}
