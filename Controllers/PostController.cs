using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlogApi2.Business_Logic;
using BlogApi2.Models;

namespace BlogApi2.Controllers
{
    [Route("api/[controller]")]
    //[Route("api/post")]
    [ApiController]
    public class PostController : ControllerBase
    {
        
        private IPostManager _postManager;

        public PostController(IPostManager postManager)
        {
            _postManager = postManager;
        }

        // GET: api/Post
        [HttpGet]
        public IEnumerable<Post> Get()
        {
            return _postManager.getAllPosts();
        }

        // GET: api/Post/5
        [HttpGet("{id}")]
        public Post Get(int id)
        {
            return _postManager.getPostById(id);
        }

        // GET: api/Post/GetAuthor/Jon
        [HttpGet("GetAuthor/{name}")]
        public IEnumerable<Post> GetAuthor(string name)
        {
            return _postManager.getPostByAuthor(name);
        }

        // GET: api/Post/GetTitles
        [HttpGet("GetTitles")]
        public IEnumerable<string> GetTitles()
        {
            return _postManager.getPostTitle();
        }

        // POST: api/Post
        [HttpPost]
        public void Post([FromBody] Post post)
        {
            _postManager.createPost(post);
        }

        // PUT: api/Post/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Post post)
        {
            _postManager.updatePost(id, post);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _postManager.deletePost(id);
        }
    }
}
