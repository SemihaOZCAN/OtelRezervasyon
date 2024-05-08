using OtelRezervasyon.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon.Repositories
{
   public class Repository<T> where T:class,new()
    {
        DbOtelRezervasyonEntities3 db = new DbOtelRezervasyonEntities3();

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();

        }
        //ekleme
        public void TAdd(T p)
        {
            db.Set<T>().Add(p);
            db.SaveChanges();

        }
        //silme
        public void TDelete(T p)
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();
        }
        //id bulma
        public T TGet(int id)
        {
            return db.Set<T>().Find(id);
        }
        //guncelle
        public void TUpdate(T p)
        {
            db.SaveChanges();
        }
        //bulma
        public T Find(Expression<Func<T,bool>> where)
        {
            return db.Set<T>().FirstOrDefault(where);
        }
        //sartlı lıstele
        public List<T> GetListByID(Expression<Func<T, bool>> filter)
        {
            return db.Set<T>().Where(filter).ToList();
        }

      
    }
}
