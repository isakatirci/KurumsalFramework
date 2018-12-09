using KurumsalFramework.Northwind.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KurumsalFramework.Core.DataAccess.EntityFramework;
using KurumsalFramework.Northwind.Entities;
using KurumsalFramework.Northwind.Entities.Concreate;

namespace KurumsalFramework.Northwind.DataAccess.Concreate.EntityFramework
{
    public class EFProductDal : EFEntityRepositoryBase<Product, NorthwindDbContext>, IProductDal
    {

    }
}
