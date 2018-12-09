using KurumsalFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurumsalFramework.Core.DataAccess.NHibernate
{
    public class NHQueryableRepository<T> : IQueryableRepository<T>
          where T : class, IEntity, new()
    {

        private NHibernateHelper _nHibernateHelper;
        private IQueryable<T> _entities;

        public NHQueryableRepository(NHibernateHelper nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
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

                return _entities ?? (_entities = _nHibernateHelper.OpenSession().Query<T>());            
            }
        }
    }
}
