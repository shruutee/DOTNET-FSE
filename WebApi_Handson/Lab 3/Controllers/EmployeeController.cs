using Lab3_WebAPI_CustomModel_Filters.Filters;
using Lab3_WebAPI_CustomModel_Filters.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab3_WebAPI_CustomModel_Filters.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ServiceFilter(typeof(CustomAuthFilter))]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new();

        public EmployeeController()
        {
            if (employees.Count == 0)
            {
                employees = GetStandardEmployeeList();
            }
        }

        [AllowAnonymous]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<Employee>> GetStandard()
        {
            // Uncomment the next line to test the Custom Exception Filter
            // throw new Exception("Sample Exception");

            return Ok(employees);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            employees.Add(employee);
            return Ok(employee);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Employee employee)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);

            if (emp == null)
                return NotFound();

            emp.Name = employee.Name;
            emp.Salary = employee.Salary;
            emp.Permanent = employee.Permanent;
            emp.Department = employee.Department;
            emp.Skills = employee.Skills;
            emp.DateOfBirth = employee.DateOfBirth;

            return Ok(emp);
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "John",
                    Salary = 60000,
                    Permanent = true,
                    Department = new Department
                    {
                        Id = 1,
                        Name = "IT"
                    },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "C#" },
                        new Skill { Id = 2, Name = "ASP.NET Core" }
                    },
                    DateOfBirth = new DateTime(1998,5,15)
                },

                new Employee
                {
                    Id = 2,
                    Name = "Alice",
                    Salary = 50000,
                    Permanent = false,
                    Department = new Department
                    {
                        Id = 2,
                        Name = "HR"
                    },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 3, Name = "Recruitment" }
                    },
                    DateOfBirth = new DateTime(1999,10,20)
                }
            };
        }
    }
}
