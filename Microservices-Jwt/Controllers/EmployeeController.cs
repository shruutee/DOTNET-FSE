using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthenticationApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(new[]
            {
                new
                {
                    Id = 1,
                    Name = "Sanjana",
                    Department = "IT"
                },
                new
                {
                    Id = 2,
                    Name = "Rahul",
                    Department = "HR"
                }
            });
        }
    }
}
