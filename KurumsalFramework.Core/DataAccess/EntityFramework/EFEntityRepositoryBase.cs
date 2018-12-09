using KurumsalFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KurumsalFramework.Core.DataAccess.EntityFramework
{
    
    //https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application
  
    public class EFEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
          where TEntity : class, IEntity, new()
          where TContext : DbContext, new()
    {
        public TEntity Add(TEntity entity)
        {
            using (var db = new TContext())
            {
                var entry = db.Entry(entity);
                entry.State = EntityState.Added;
                db.SaveChanges();
                return entity;
            }
        }

        public void Delete(TEntity entity)
        {
            using (var db = new TContext())
            {
                var entry = db.Entry(entity);
                entry.State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var db = new TContext())
            {
                return db.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var db = new TContext())
            {
                return filter != null ?
                    db.Set<TEntity>().Where(filter).ToList()
                    : db.Set<TEntity>().ToList();
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (var db = new TContext())
            {
                var entry = db.Entry(entity);
                entry.State = EntityState.Modified;
                db.SaveChanges();
                return entity;
            }
        }
    }
}
