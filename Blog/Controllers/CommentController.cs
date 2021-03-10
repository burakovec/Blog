using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
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
