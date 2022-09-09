using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Report
{

    public class UnitOfWork
    {
        private  NorthWindEntities db = new NorthWindEntities();

        public void SaveChanges()
        {
            db.SaveChanges();
        }

        public GenericRepo<Region> GetRegionRepo()
        {
            return new GenericRepo<Region>(db);
        }

        public GenericRepo<Category> GetCategoryRepo()
        {
            return new GenericRepo<Category>(db);
        }

    }

    public  class GenericRepo<T> where T : class
    {
        private readonly NorthWindEntities db;

        public GenericRepo(NorthWindEntities db)
        {
            this.db = db;
        }

        public void Create(T model)
        {
            db.Set<T>().Add(model);
            //db.SaveChanges();
        }

        public void Update(T model)
        {
            db.Entry(model).State = System.Data.Entity.EntityState.Modified;
            //db.SaveChanges();
        }

        public T Find(int id)
        {
            return db.Set<T>().Find(id);
        }

        public void Delete(T model)
        {
            db.Entry(model).State = System.Data.Entity.EntityState.Deleted;
            //db.SaveChanges();
        }

        public void Delete(int id)
        {
            var model = Find(id);
            db.Entry(model).State = System.Data.Entity.EntityState.Deleted;
            //db.SaveChanges();
        }

        public IQueryable<T> All()
        {
            return db.Set<T>().AsQueryable();
        }
    }
}
