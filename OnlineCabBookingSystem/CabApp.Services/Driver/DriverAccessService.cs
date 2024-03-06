using CabApp.Data;
using CabApp.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Services
{
    public class DriverAccessService : IDriverAccessService
    {
        //object of db context class
        private readonly CabAppDbContext context;

        //constructor Dependency injection
        public DriverAccessService(CabAppDbContext context)
        {
            this.context = context;
        }



        //when driver try to sign in ,if successfull it wil return list of claims otherwise exception
        public List<Claim> DriverSignIn(DriverSignInRequest request)
        {
            var driver = context.Drivers.FirstOrDefault(d => d.Email == request.Email
                                        && d.Password == request.Password);

            if (driver == null)
                throw new AuthenticationException("Login Failed");

            var result = new List<Claim> {
                new Claim("Email",driver.Email),
                new Claim(ClaimTypes.NameIdentifier,driver.Name),
            };

            return result;
        }


        //when driver try to sign up ,it will check if he/she is already in the database or not,otherwise ,his details go for registration.
        public Driver DriverSignUp(DriverSignUpRequest request)
        {
            //Check if the email is already in use
            if (context.Drivers.Any(d => d.Email == request.Email))
                throw new DuplicateEmailException("Email already exist");

            var driver = new Driver();

            driver.Email = request.Email;
            driver.Name = request.Name;
            driver.Password = request.Password;

            context.Drivers.Add(driver);
            context.SaveChanges();

            return driver;
        }
    }
}
