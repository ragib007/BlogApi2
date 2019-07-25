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
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private IAuthorManager _authorManager;

        public AuthorController(IAuthorManager authorManager)
        {
            _authorManager = authorManager;
        }

        // GET: api/Author
        [HttpGet]
        public IEnumerable<Author> Get()
        {
            return _authorManager.getAllAuthors();
        }

        // GET: api/Author/5
        [HttpGet("{id}")]
        public Author Get(int id)
        {
            return _authorManager.getAuthorById(id);
        }

        // GET: api/Author/GetAuthorPosts/Jon
        [HttpGet("GetAuthorPosts/{name}")]
        public IEnumerable<Post> GetAuthorPosts(string name)
        {
            return _authorManager.getAuthorPosts(name);
        }

        // POST: api/Author
        [HttpPost]
        public void Post([FromBody] Author author)
        {
            _authorManager.createAuthor(author);
        }

        // PUT: api/Author/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Author author)
        {
            _authorManager.updateAuthor(id,author);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _authorManager.deleteAuthor(id);
        }
    }
}
