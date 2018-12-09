using KurumsalFramework.Core.DataAccess.NHibernate;
using KurumsalFramework.Northwind.DataAccess.Abstract;
using KurumsalFramework.Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurumsalFramework.Northwind.DataAccess.Concreate.NHibernate
{
    public class NHCategoryDal : NHEntityRepositoryBase<Category>, ICategoryDal

    {
        public NHCategoryDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
        }
    }
}
