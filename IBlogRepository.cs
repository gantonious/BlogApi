using BlogApi.Models;
using System.Collections.Generic;

namespace BlogApi {
    public interface IBlogRepository 
    {
        IEnumerable<BlogPost> GetAll();
        void CreatePost(BlogPost blogPost);
        void DeletePost(string blogId);
    }
}