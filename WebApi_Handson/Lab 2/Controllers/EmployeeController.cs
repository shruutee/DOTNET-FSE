using Microsoft.AspNetCore.Mvc;
using Lab2_WebAPI_Swagger.Models;

namespace Lab2_WebAPI_Swagger.Controllers
{
    [ApiController]
    [Route("api/Emp")]   // Modified route from Employee to Emp
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new()
        {
            new Employee { Id = 1, Name = "John", Department = "IT", Salary = 50000 },
            new Employee { Id = 2, Name = "Alice", Department = "HR", Salary = 45000 },
            new Employee { Id = 3, Name = "Bob", Department = "Finance", Salary = 60000 }
        };

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetEmployees()
        {
            return Ok(employees);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddEmployee(Employee employee)
        {
            employees.Add(employee);
            return Ok(employee);
        }
    }
}
