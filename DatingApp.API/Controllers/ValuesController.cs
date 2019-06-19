using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // private readonly DataContext context;
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            // this.context = context;
            _context = context;

        }
        // GET api/values
        [HttpGet]
        // public ActionResult<IEnumerable<string>> Get()
            // instead we'll use IActionResult, it allows us to return HTTP responses to the client
        // public IActionResult GetValues()
            // we make this thread asynchronous
        public async Task<IActionResult> GetValues()
        {
            // var values = _context.Values.ToList();
            var values = await _context.Values.ToListAsync();
            return Ok(values);
                // this line will return our values variable with an http ok response
        }

        // GET api/values/5
        [HttpGet("{id}")]
        // public ActionResult<string> Get(int id)
        public async Task<IActionResult> GetValue(int id)
        {
            // return "value";
            var value = await _context.Values.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(value);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
