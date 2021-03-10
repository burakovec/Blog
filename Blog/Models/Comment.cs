using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Content { get; set; }
        public int PostID { get; set; }

    }
}
