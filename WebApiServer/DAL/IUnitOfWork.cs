using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiServer.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        AppDBContext DbContext { get; }
        int Save();
    }
}