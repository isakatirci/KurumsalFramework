using System;
using KurumsalFramework.Northwind.DataAccess.Concreate.EntityFramework;
using KurumsalFramework.Northwind.DataAccess.Concreate.NHibernate;
using KurumsalFramework.Northwind.DataAccess.NHibernate.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KurumsalFramework.DataAccess.Tests.NHibernateTests
{
    [TestClass]
    public class NHibernateTests
    {
        [TestMethod]
        public void Get_products_count()
        {
            NHProductDal dal = new NHProductDal(new SqlServerHelper());
            var list = dal.GetList();
            Assert.AreEqual(77, list.Count);
        }
    }
}
