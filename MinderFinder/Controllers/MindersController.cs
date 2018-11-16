using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinderFinder.BackEnd.Interfaces;
using MinderFinder.BackEnd.Models;

namespace MinderFinder.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MindersController : Controllerk
    {

        private readonly IRepository<Minder> _IRepository;

        public MindersController(IRepository<Minder> IRepository)
        {
            _IRepository = IRepository;
            _IRepository.GetAll();
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
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
