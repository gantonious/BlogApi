using System;

namespace BlogApi.Models {
    public class BlogPost {
        public string Id { get; set; }
        public string Title { get; set; }
        public DateTime DatePosted { get; set; }
        public string Content { get; set; }
    }
}