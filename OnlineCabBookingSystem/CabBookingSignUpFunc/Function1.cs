using CabApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace CabBookingSignUpFunc
{
    public class Function1
    {
        private readonly ILogger<Function1> _logger;
        private readonly ICustomerAccessService customerAccessService;

        public Function1(ILogger<Function1> logger,ICustomerAccessService customerAccessService)
        {
            _logger = logger;
            this.customerAccessService = customerAccessService;
        }

        [Function("Function1")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "post")] HttpRequest req)
        {
            var body = await new StreamReader(req.Body).ReadToEndAsync();
            var signUpRequest = JsonSerializer.Deserialize<CustomerSignUprequest>(body);
            var customer = customerAccessService.CustomerSignUp(signUpRequest);

            return new OkObjectResult(new { Name  = customer.Name, Email = customer.Email});
        }
    }
}
