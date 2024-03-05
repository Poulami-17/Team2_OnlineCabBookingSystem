using CabApp.Data;
using CabApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Services
{
    public class AdminAccessService : IAdminAccessService
    {
        private readonly CabAppDbContext _dbContext;
        public AdminAccessService(CabAppDbContext _dbContext)
        {
            this._dbContext = _dbContext;
        }

        public List<Claim> AdminSignIn(DriverSignInRequest request)
        {
           var admin = _dbContext.Admins.FirstOrDefault(d=>d.Email== request.Email && d.Password == request.Password);
            if(admin == null)
            {
                throw new AuthenticationException("Login Failed");
            }
            var result = new List<Claim>
            {
                new Claim("Email",admin.Email),
                new Claim(ClaimTypes.NameIdentifier,admin.Name),
            };
            return result;
        }

        public Admin AdminSignUp(AdminSignUpRequest request)
        {
            if (_dbContext.Admins.Any(d => d.Email == request.Email))
                throw new DuplicateEmailException("Email already exist");

            var admin = new Admin();
            admin.Name = request.Name;
            admin.Email = request.Email;
            admin.Password = request.Password;
            admin.PhoneNumber = 0;
            admin.UserName = request.UserName;
            
            
            

            _dbContext.Admins.Add(admin);
            _dbContext.SaveChanges();

            return admin;
        }



        //View Customer
        public async Task<List<Customer>> ViewAllCustomerAsync()
        {
            return await _dbContext.Customers.ToListAsync();

        }


        //Add Driver
        public async Task AddDriversAsync(Driver driver)
        {
            await _dbContext.Set<Driver>().AddAsync(driver);
            await _dbContext.SaveChangesAsync();
        }


        //View All Driver
        public async Task<List<Driver>> ViewAllDriverAsync()
        {
            return await _dbContext.Drivers.ToListAsync();

        }

        //public async Task<Driver> ViewDriverByIdAsync(int  id)
        //{
        //    return await _dbContext.Drivers.FindAsync(id);
        //}

        //public async Task<>



    }
}
