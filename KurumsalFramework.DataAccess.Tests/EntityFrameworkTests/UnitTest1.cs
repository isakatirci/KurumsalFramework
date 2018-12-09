using System;
using KurumsalFramework.Northwind.DataAccess.Concreate.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KurumsalFramework.DataAccess.Tests.EntityFrameworkTests
{
    [TestClass]
    public class EntityFrameworkTests
    {
        [TestMethod]
        public void Get_products_count()
        {
            EFProductDal dal = new EFProductDal();
            var list = dal.GetList();
            Assert.AreEqual(77, list.Count);
        }
    }
}
