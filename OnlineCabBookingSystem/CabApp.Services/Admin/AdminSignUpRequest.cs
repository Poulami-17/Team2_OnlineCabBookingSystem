using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabApp.Services
{
    public class AdminSignUpRequest
    {
        public string Name { get; set; }
        public string UserName {  get; set; }
        public string Email { get; set; }   
        public string Password { get; set; }
    }
}
