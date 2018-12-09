using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurumsalFramework.Core.DataAccess.NHibernate
{
    public abstract class NHibernateHelper : IDisposable
    {
        //https://docs.microsoft.com/tr-tr/dotnet/api/system.idisposable?view=netframework-4.7.2
        // Flag: Has Dispose already been called?
        private bool _disposed = false;
        private static ISessionFactory sessionFactory;

        public virtual ISessionFactory SessionFactory {
            get { return sessionFactory ?? (sessionFactory = InitializeFactory()); }
        }

        public virtual ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        public abstract ISessionFactory InitializeFactory();

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                //
            }

            // Free any unmanaged objects here.
            //
            _disposed = true;
        }

        ~NHibernateHelper()
        {
            Dispose(false);
        }
    }
}


