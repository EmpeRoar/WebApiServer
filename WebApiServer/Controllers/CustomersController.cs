using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiServer.DAL;
using WebApiServer.Helpers;
using WebApiServer.Models;
using WebApiServer.Repositories.Customers;

namespace WebApiServer.Controllers
{
    public class CustomersController : ApiController
    {
        private readonly ICustomersRepository _customersRepository;
        public CustomersController(ICustomersRepository customersRepository)
        {
            _customersRepository = customersRepository;
        }

      

        // GET: api/Customers
        public async Task<IQueryable<Customer>> GetCustomers()
        {
            Expression<Func<Customer, bool>> Expression;
            Expression = x => x.ID != 0;
            
            Expression = Utils.Combine(Expression, x => x.CustomerStatus == CustomerStatus.active);
           

            var customers = await _customersRepository.FindAll(Expression);
            return customers;
        }

        // GET: api/Customers/5
        [ResponseType(typeof(Customer))]
        public async Task<IHttpActionResult> GetCustomer(int id)
        {
            Customer customer = await _customersRepository.GetByID(id);
            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        // PUT: api/Customers/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCustomer(int id, Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != customer.ID)
            {
                return BadRequest();
            }
            customer.Updated = DateTime.Now;
            _customersRepository.Update(customer);

           

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Customers
        [ResponseType(typeof(Customer))]
        public async Task<IHttpActionResult> PostCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            customer.Created = DateTime.Now;
            _customersRepository.Add(customer);

            return Ok(customer);
        }

        // DELETE: api/Customers/5
        [ResponseType(typeof(Customer))]
        public async Task<IHttpActionResult> DeleteCustomer(int id)
        {
            //Customer customer = await db.Customers.FindAsync(id);
            //if (customer == null)
            //{
            //    return NotFound();
            //}

            //db.Customers.Remove(customer);
            //await db.SaveChangesAsync();

            //return Ok(customer);
            return Ok();
        }

        

        private async Task<bool> CustomerExists(int id)
        {
            //return db.Customers.Count(e => e.ID == id) > 0;
            var customers = await _customersRepository.FindAll();
            return customers.Count() > 0;
        }
    }
}