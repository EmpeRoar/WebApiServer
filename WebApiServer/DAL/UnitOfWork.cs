using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiServer.DAL
{
    public class UnitOfWork : IUnitOfWork
    {

        private AppDBContext context;

        public AppDBContext DbContext
        {
            get
            {
                if (context == null)
                {
                    context = new AppDBContext();
                }
                return context;
            }
        }

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (context != null)
                {
                    context.Dispose();
                    context = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public int Save()
        {
            return context.SaveChanges();
        }
    }
}