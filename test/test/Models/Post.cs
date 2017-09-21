using System;
using System.Collections.Generic;

namespace test.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SiteUrl { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }

        public Fan Author { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}