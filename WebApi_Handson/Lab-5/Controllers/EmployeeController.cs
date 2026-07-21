using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    [Authorize(Roles = "Admin,POC")]

    public class EmployeeController : ControllerBase
    {
        static List<Employee> employees = new List<Employee>()
        {
            new Employee
            {
                Id=1,
                Name="Rahul",
                Department="IT",
                Salary=50000
            },
            new Employee
            {
                Id=2,
                Name="Amit",
                Department="HR",
                Salary=40000
            }
        };

        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            var emp = employees.FirstOrDefault(x => x.Id == id);

            if (emp == null)
                return NotFound();

            return Ok(emp);
        }
    }
}
