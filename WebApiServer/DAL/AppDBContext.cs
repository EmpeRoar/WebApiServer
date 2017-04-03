using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApiServer.Models;

namespace WebApiServer.DAL
{
   
    public class AppDBContext : IdentityDbContext<ApplicationUser>,IDbContext
    {
        public AppDBContext()
            : base("AppDBContext", throwIfV1Schema: false)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        public static AppDBContext Create()
        {
            return new AppDBContext();
        }
        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}