using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMvcReactJS.Models
{
    public class CommentModel
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
    }
}