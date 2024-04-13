using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Catering_WebAPI.Entities;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Catering_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetAllCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                    CustomerId = 1,
                    Name = "Jakub",
                    Email = "jakubbolek02@gmail.com",
                    Country = "Poland"
                }
            };

            return Ok(customers);
        }
    }
}
