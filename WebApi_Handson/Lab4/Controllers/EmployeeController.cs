using Microsoft.AspNetCore.Mvc;
using Lab4_WebAPI_CRUD.Models;

namespace Lab4_WebAPI_CRUD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new()
        {
            new Employee
            {
                Id = 1,
                Name = "John",
                Salary = 50000,
                Permanent = true,
                Department = new Department
                {
                    Id = 1,
                    Name = "IT"
                },
                Skills = new List<Skill>
                {
                    new Skill{Id=1,Name="C#"},
                    new Skill{Id=2,Name="ASP.NET"}
                },
                DateOfBirth = new DateTime(1998,5,10)
            },

            new Employee
            {
                Id = 2,
                Name = "Alice",
                Salary = 45000,
                Permanent = false,
                Department = new Department
                {
                    Id = 2,
                    Name = "HR"
                },
                Skills = new List<Skill>
                {
                    new Skill{Id=3,Name="Communication"}
                },
                DateOfBirth = new DateTime(1999,8,15)
            }
        };

        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(employees);
        }

        [HttpPost]
        public ActionResult<Employee> Post([FromBody] Employee employee)
        {
            employees.Add(employee);

            return Ok(employee);
        }

        [HttpPut("{id}")]
        public ActionResult<Employee> Put(int id, [FromBody] Employee employee)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            var emp = employees.FirstOrDefault(e => e.Id == id);

            if (emp == null)
            {
                return BadRequest("Invalid employee id");
            }

            emp.Name = employee.Name;
            emp.Salary = employee.Salary;
            emp.Permanent = employee.Permanent;
            emp.Department = employee.Department;
            emp.Skills = employee.Skills;
            emp.DateOfBirth = employee.DateOfBirth;

            return Ok(emp);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);

            if (emp == null)
            {
                return BadRequest("Invalid employee id");
            }

            employees.Remove(emp);

            return Ok("Employee deleted successfully.");
        }
    }
}
