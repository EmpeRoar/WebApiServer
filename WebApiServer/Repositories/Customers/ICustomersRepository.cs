using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiServer.Models;

namespace WebApiServer.Repositories.Customers
{
   

    public interface ICustomersRepository : IBaseRepository<Customer>
    {
        Task<Customer> GetByID(int id);
    }
}
