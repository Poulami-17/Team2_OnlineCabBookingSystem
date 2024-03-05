using CabApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Services
{
    public interface ICustomerAccessService
    {
        Customer CustomerSignUp(CustomerSignUprequest request);
        List<Claim> CustomerSignIn(CustomerSignInRequest request);
    }
}
