using BlogApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
{
    [Route("api/[controller]")]
    public class BlogController : Controller
    {
        private readonly IBlogRepository _blogRepository;
        public BlogController(IBlogRepository blogRepository) {
            _blogRepository = blogRepository;
        }

        [HttpGet]
        public IEnumerable<BlogPost> Get()
        {
            return _blogRepository.GetAll();
        }

        [HttpGet("{id}")]
        public BlogPost Get(string id)
        {
            return _blogRepository.GetAll()
                                  .Where(blogPost => blogPost.Id == id)
                                  .FirstOrDefault();
        }

        [HttpPost]
        public IActionResult Post([FromBody]BlogPost blogPost)
        {
            blogPost.Id = Guid.NewGuid().ToString();
            _blogRepository.CreatePost(blogPost);

            return Created("blog post", blogPost);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
