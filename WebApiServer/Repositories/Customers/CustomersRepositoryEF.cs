using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebApiServer.DAL;
using WebApiServer.Models;

namespace WebApiServer.Repositories.Customers
{
    public class CustomersRepositoryEF : BaseRepositoryEF<Customer>, ICustomersRepository
    {
        private AppDBContext _context;
        public CustomersRepositoryEF(AppDBContext context) : base(context)
        {
            _context = context;
        }
        public async Task<Customer> GetByID(int id)
        {
            return await _context.Set<Customer>().Where(x => x.ID == id).FirstOrDefaultAsync();
        }
    }
}