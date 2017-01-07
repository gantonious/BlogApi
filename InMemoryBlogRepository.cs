using System;
using System.Collections.Generic;
using BlogApi.Models;

namespace BlogApi {
    public class InMemoryBlogRepository : IBlogRepository
    {
        private Dictionary<string, BlogPost> blogDictionary = new Dictionary<string, BlogPost>();
        
        public void CreatePost(BlogPost blogPost)
        {
            blogDictionary[blogPost.Id] = blogPost;
        }

        public void DeletePost(string blogId)
        {
            blogDictionary.Remove(blogId);
        }

        public IEnumerable<BlogPost> GetAll()
        {
            return blogDictionary.Values;
        }
    }
}