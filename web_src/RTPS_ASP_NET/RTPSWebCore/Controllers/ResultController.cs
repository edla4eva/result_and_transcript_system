using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RTPSWebCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultController : ControllerBase
    {
        //// GET: api/<ResultsController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<ResultsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return string.Format( "The response for {0} is 777",id);

        }

        // GET api/<ResultsController>
        [HttpGet("{matno}")]
        public IEnumerable<Result> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Result
            {
                Date = DateTime.Now.AddDays(index),
                MatNo = "ENG1201257",
                Scores = new int[]{ 12, 34, 56, 87, 89, 90 },
                Remarks="Very good outing"
            })
            .ToArray();
        }
        // POST api/<ResultsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ResultsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ResultsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
