using KurumsalFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurumsalFramework.Core.DataAccess.EntityFramework
{
    public class EFQueryableRepository<T> : IQueryableRepository<T>
          where T : class, IEntity, new()
    {
        private IQueryable<T> _entities;
        private DbContext _context;
        public EFQueryableRepository(DbContext context)
        {
            _context = context;
        }
        public IQueryable<T> Table
        {
            get
            {
                return Entities;
            }
        }

        protected virtual IQueryable<T> Entities
        {
            get
            {

                if (_entities == null)
                {
                    _entities = _context.Set<T>();
                }

                return _entities;
            }
        }
    }
}
