namespace WebApiServer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApiServer.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApiServer.DAL.AppDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApiServer.DAL.AppDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            

            //context.Customers.Add(new Customer()
            //{
            //    FirstName = "Julius",
            //    MiddleName = "Cabatana",
            //    LastName = "Bacosa",
            //    Email = "juliusbacosa@gmail.com",                
            //    Created = DateTime.Now
            //});

            //context.Customers.Add(new Customer()
            //{
            //    FirstName = "Jessica",
            //    MiddleName = "Alba",
            //    LastName = "Bacosa",
            //    Email = "jessicaalba@gmail.com",                
            //    Created = DateTime.Now
            //});
            //context.SaveChanges();
        }
    }
}
