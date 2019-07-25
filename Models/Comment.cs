using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApi2.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public Author author { get; set; }

        public Post post { get; set; }

        public DateTime CreatedAt { get; set; }


    }
}
