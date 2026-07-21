using Microsoft.AspNetCore.Mvc;

namespace Lab1_FirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private static List<string> values = new List<string>
        {
            "Laptop",
            "Mouse",
            "Keyboard"
        };

        // GET
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(values);
        }

        // GET by ID
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id < 0 || id >= values.Count)
                return BadRequest("Invalid Id");

            return Ok(values[id]);
        }

        // POST
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            values.Add(value);
            return Ok("Data Added Successfully");
        }

        // PUT
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            if (id < 0 || id >= values.Count)
                return BadRequest("Invalid Id");

            values[id] = value;

            return Ok("Data Updated Successfully");
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0 || id >= values.Count)
                return BadRequest("Invalid Id");

            values.RemoveAt(id);

            return Ok("Data Deleted Successfully");
        }
    }
}
