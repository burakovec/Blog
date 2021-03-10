using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Tag
    {
        public int ID { get; set; }
        public int PostID { get; set; }
        public string Name { get; set; }
    }
}
