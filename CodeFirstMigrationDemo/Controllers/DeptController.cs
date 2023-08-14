using CodeFirstMigrationDemo.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodeFirstMigrationDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeptController : ControllerBase
    {
        Models.DeptContext _db;


        public DeptController(Models.DeptContext db)
        {
            _db = db;
        }


        // GET: api/<DeptController>
        [HttpGet]
        public IEnumerable<Department> GetAllDepts()
        {
            return _db.Departments.ToList();
        }

        // GET api/<DeptController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DeptController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DeptController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DeptController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
