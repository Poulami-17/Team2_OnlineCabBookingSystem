using CabApp.Data;
using CabApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Services
{
    public class AdminViewCustomerService
    {
        // declare the dbContext
        private readonly CabAppDbContext _dbContext;

        //injecting the dbcontext using constructor
        public AdminViewCustomerService(CabAppDbContext _dbContext)
        {
            this._dbContext = _dbContext;
        }


        //This is to View all Customer details
        public async Task<List<Customer>> ViewAllCustomerAsync()
        {
            return await _dbContext.Customers.ToListAsync();

        }

    }
}
