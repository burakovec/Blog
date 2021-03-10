using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class GeneralResponse<T>
    {
        public T Content { get; set; }

        public bool IsError => false;
    }
    public class GeneralResponse
    {
        public string ErrorMessage { get; set; }
        public bool IsError => true;

    }
}
