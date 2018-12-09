using KurumsalFramework.Northwind.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KurumsalFramework.Core.DataAccess.EntityFramework;
using KurumsalFramework.Northwind.Entities;
using KurumsalFramework.Core.DataAccess.NHibernate;
using KurumsalFramework.Northwind.Entities.Concreate;

namespace KurumsalFramework.Northwind.DataAccess.Concreate.NHibernate
{
    public class NHProductDal : NHEntityRepositoryBase<Product>, IProductDal
    {
        public NHProductDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
        }
    }
}
