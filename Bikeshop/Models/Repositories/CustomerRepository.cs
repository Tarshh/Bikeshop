using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bikeshop.Models.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Bikeshop.Models.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _bikDbContext;

        public CustomerRepository(AppDbContext bikDbContext)
        {
            _bikDbContext = bikDbContext;
        }

        public void AddCustomer(Customer customer)
        {
            _bikDbContext.Customers.Add(customer);
            _bikDbContext.SaveChanges();
        }

        public Customer GetCustomer(string customerId)
        {
            return _bikDbContext.Customers.FirstOrDefault(c => c.Id == customerId);
        }
    }
}
