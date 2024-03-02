using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using CabApp.Entities;

namespace CabApp.Repositories
{
    public interface ICustomerRepository
    {
        Customer SignUp(SignUpRequest request);
        List<Claim> SignIn(SignInRequest request);

    }
}
