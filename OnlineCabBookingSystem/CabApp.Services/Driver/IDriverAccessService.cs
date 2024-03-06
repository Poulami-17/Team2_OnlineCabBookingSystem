using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using CabApp.Entities;

namespace CabApp.Services
{
    public interface IDriverAccessService
    {
        //method which is responsible for taking signup details and saving it in the database
        Driver DriverSignUp(DriverSignUpRequest request);

        //method which is responsible for checking credentials given by driver from the database and  give login permission
        List<Claim> DriverSignIn(DriverSignInRequest request);
    }
}
