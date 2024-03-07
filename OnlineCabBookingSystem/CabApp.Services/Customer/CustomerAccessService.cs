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
using CabApp.Data;
using CabApp.Entities;

namespace CabApp.Services
{
    public class CustomerAccessService : ICustomerAccessService
    {
        private readonly CabAppDbContext context;


        public CustomerAccessService(CabAppDbContext context)
        {
            this.context = context;
        }

        //method which is responsible for checking credentials given by customer from the database 
        //when customer try to sign in ,if successfull it wil return list of claims otherwise exception
        public List<Claim> CustomerSignIn(CustomerSignInRequest request)
        {
            var customer = context.Customers.FirstOrDefault(d => d.Email == request.Email
                                        && d.Password == request.Password);

            if (customer == null)
                throw new AuthenticationException("Login Failed");

            var result = new List<Claim> {
                new Claim("Email",customer.Email),
                new Claim(ClaimTypes.NameIdentifier,customer.Name),
            };

            return result;
        }

        //method which is responsible for taking signup details for customer and saving it in the database
        //when customer try to sign up ,it will check if he/she is already in the database or not,otherwise ,his details go for registration.
        public Customer CustomerSignUp(CustomerSignUprequest request)
        {
            //Check if the email is already in use
            if (context.Customers.Any(d => d.Email == request.Email))
                throw new DuplicateEmailException("Email already exist");

            var customer = new Customer();
            customer.Email = request.Email;
            customer.Address = "Not Updated";
            customer.Name = request.Name;
            customer.Password = request.Password;
            customer.PhoneNumber = 0;
            customer.UserName = "";

            context.Customers.Add(customer);
            context.SaveChanges();

            return customer;
        }
    }
}
