using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fruit_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace fruit_api.Controllers
{
    [Route("api/[controller]")]
    public class FruitController : Controller
    {
        private readonly FruitContext _context;

        public FruitController(FruitContext context)
        {
            _context = context;

            if (_context.FruitItems.Count() == 0)
            {
                _context.FruitItems.Add(new FruitItem { Name = "Item1" });
                _context.SaveChanges();
            }
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<FruitItem> GetAll()
        {
            return _context.FruitItems.ToList();
        }
        // public IEnumerable<string> Get()
        // {
        //     return new string[] { "value1", "value2" };
        // }

        // // GET api/values/5
        // [HttpGet("{id}")]
        // public string Get(int id)
        // {
        //     return "value";
        // }

        // // POST api/values
        // [HttpPost]
        // public void Post([FromBody]string value)
        // {
        // }

        // // PUT api/values/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody]string value)
        // {
        // }

        // // DELETE api/values/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }
    }
}
