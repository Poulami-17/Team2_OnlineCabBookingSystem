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


        //method which is responsible for checking credentials given by admin from the database 
        //when admin try to sign in ,if successfull it wil return list of claims otherwise exception
        public List<Claim> AdminSignIn(AdminSignInRequest request)
        {
            var admin = _dbContext.Admins.FirstOrDefault(d => d.Email == request.Email && d.Password == request.Password);
            if (admin == null)
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



    }
}
