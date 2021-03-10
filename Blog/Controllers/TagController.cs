using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 

namespace Blog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    { 
        [HttpGet]
        public IActionResult Get()
        {
            //todo:1
            return Ok();
        }
         
        [HttpGet("{ID}")]
        public IActionResult Get(int ID)
        {
            //todo:2
            return Ok();
        }
         
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            //todo:3
            return Ok();
        }
         
        [HttpPut("{ID}")]
        public IActionResult Put(int ID, [FromBody] string value)
        {
            //todo:4
            return Ok();
        } 

        [HttpDelete("{ID}")]
        public IActionResult Delete(int ID)
        {
            //todo:5
            return Ok();
        }
    }
}
