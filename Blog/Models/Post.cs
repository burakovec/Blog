using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Content { get; set; }
        public int LikeCount { get; set; }
    }
}
