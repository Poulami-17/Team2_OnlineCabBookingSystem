using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using CabApp.Entities;

namespace CabApp.Services
{
    public interface IAdminAccessService
    {
        Admin AdminSignUp(AdminSignUpRequest request);
        List<Claim> AdminSignIn(AdminSignInRequest request);
    }
}
