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
    //[Route("api/comment")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        public ICommentManager _commentManager;

        public CommentController(ICommentManager commentManager)
        {
            _commentManager = commentManager;
        }


        // GET: api/Comment
        [HttpGet]
        public IEnumerable<Comment> Get()
        {
            return _commentManager.getAllComments();
        }

        // GET: api/Comment/5
        [HttpGet("{id}")]
        public Comment Get(int id)
        {
            return _commentManager.getCommentById(id);
        }

        // GET: api/Comment/GetByPost/5
        [HttpGet("GetByPost/{id}")]
        public IEnumerable<Comment> GetByPost(int id)
        {
            return _commentManager.getCommentByPost(id);
        }

        // POST: api/Comment
        [HttpPost]
        public void Post([FromBody] Comment comment)
        {
            _commentManager.createComment(comment);
        }

        // PUT: api/Comment/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Comment comment)
        {
            _commentManager.updateComment(id, comment);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _commentManager.deleteComment(id);
        }
    }
}
