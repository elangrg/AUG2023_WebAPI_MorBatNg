using Microsoft.AspNetCore.Mvc;
using WebAPICodeFirstCreateDB.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPICodeFirstCreateDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoAppController : ControllerBase
    {

        Models.ToDoDbContext _db;

        public ToDoAppController(ToDoDbContext db)
        {
            _db = db;
        }


        // GET: api/<ToDoAppController>
        [HttpGet]
        public IEnumerable<Models.ToDoItem> GetAllToDoitems()
        {
            return _db.ToDoItems.ToList();
        }

        // GET api/<ToDoAppController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ToDoAppController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ToDoAppController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ToDoAppController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
