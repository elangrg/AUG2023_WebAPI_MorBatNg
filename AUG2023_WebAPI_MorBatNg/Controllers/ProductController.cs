using AUG2023_WebAPI_MorBatNg.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AUG2023_WebAPI_MorBatNg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        Models.KNDProductDbContext _db;
        public ProductController(Models.KNDProductDbContext db)
        {
            _db = db;
        }




        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _db.Products.ToList();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Product GetProductByID(int id)
        {
            return _db.Products.Find(id) ;
        }

        // POST api/<ProductController>
        [HttpPost]
        public void AddNewProduct(Models.Product product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();  
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void UpdateProduct(int id, Models.Product product)
        {
            _db.Products.Update(product);
            _db.SaveChanges();
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void RemoveProductByID(int id)
        {
            _db.Products.Remove(_db.Products.Find(id ));
            _db.SaveChanges();
        }
    }
}
