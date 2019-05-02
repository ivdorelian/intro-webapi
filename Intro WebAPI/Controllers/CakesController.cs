using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intro_WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Intro_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CakesController : ControllerBase
    {
        private IntroDbContext context;

        public CakesController(IntroDbContext context)
        {
            this.context = context;
        }

        // GET: api/Cakes
        [HttpGet]
        public IEnumerable<Cake> Get()
        {
            return context.Cakes;
        }

        // GET: api/Cakes/5
        [HttpGet("{id}", Name = "Get")]
        public Cake Get(int id)
        {
            return context.Cakes.FirstOrDefault(c => c.Id == id);
        }

        // POST: api/Cakes
        [HttpPost]
        public IActionResult Post([FromBody] Cake cake)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.Cakes.Add(cake);
            context.SaveChanges();
            return Ok();
        }

        // PUT: api/Cakes/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Cake cake)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var existing = context.Cakes.FirstOrDefault(c => c.Id == id);
            if (existing != null)
            {
                cake.Id = existing.Id;
                context.Cakes.Remove(existing);
            }
            context.Cakes.Add(cake);
            context.SaveChanges();
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var found = context.Cakes.FirstOrDefault(c => c.Id == id);
            if (found == null)
            {
                return NotFound();
            }
            context.Cakes.Remove(found);
            context.SaveChanges();
            return Ok();
        }
    }
}
