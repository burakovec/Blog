using Blog.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks; 

namespace Blog.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    { 
        [HttpGet]
        public IActionResult Get()
        {
            try
            { 
                using (System.Data.IDbConnection con = new SqlConnection(BlogSettings.ConnectionString))
                {
                    return Ok(new GeneralResponse<IEnumerable<Post>>()
                    {
                        IsError=false,
                        Content = con.Query<Post>("SELECT * FROM Post")
                    }); 
                }
            }
            catch (Exception ex)
            {
                return Ok(new GeneralResponse
                {
                    IsError = true,
                    ErrorMessage = ex.Message
                });
            }
        }

        [HttpGet("{ID}")]
        public IActionResult Get(int ID)
        {
            try
            { 
                using (System.Data.IDbConnection con = new SqlConnection(BlogSettings.ConnectionString))
                {
                    return Ok(new GeneralResponse<Post>()
                    {
                        IsError = false,
                        Content = con.QueryFirstOrDefault<Post>("SELECT * FROM Post WHERE ID = @ID",new { ID })
                    });
                }
            }
            catch (Exception ex)
            {
                return Ok(new GeneralResponse
                {
                    IsError = true,
                    ErrorMessage = ex.Message
                });
            }
        }
         
        [HttpPost]
        public IActionResult Post([FromBody] Post post)
        {
            try
            {  
                using (System.Data.IDbConnection con = new SqlConnection(BlogSettings.ConnectionString))
                {
                    return Ok(new GeneralResponse<Post>()
                    {
                        IsError = false,
                        Content = con.QueryFirstOrDefault<Post>("INSERT INTO Post (Image ,Title ,CreatedTime ,Content ,LikeCount) OUTPUT inserted.* VALUES (@Image ,@Title ,GETDATE(), @Content ,@LikeCount)", post)
                    });
                }
            }
            catch (Exception ex)
            {
                return Ok(new GeneralResponse
                {
                    IsError = true,
                    ErrorMessage = ex.Message
                });
            } 
        }
         
        [HttpPut("{ID}")]
        public IActionResult Put(int ID, [FromBody] string value)
        {
            //todo: update işlemi yapılacak
            return Ok();
        }
         
        [HttpDelete("{ID}")]
        public IActionResult Delete(int ID)
        {
            try
            {
                using (System.Data.IDbConnection con = new SqlConnection(BlogSettings.ConnectionString))
                {
                    return Ok(new GeneralResponse<int>()
                    {
                        IsError = false,
                        Content = con.Execute("DELETE FROM Post WHERE ID = @ID",new { ID })
                    });
                }
            }
            catch (Exception ex)
            {
                return Ok(new GeneralResponse
                {
                    IsError = true,
                    ErrorMessage = ex.Message
                });
            }
        }
    }
}
