using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApi2.Repositories;
using BlogApi2.Models;

namespace BlogApi2.Business_Logic
{
    public class CommentManager : ICommentManager
    {

        ICommentRepository commentRepository = new CommentRepository();

        public List<Comment> getAllComments()
        {
            return commentRepository.getAll();
        }

        public Comment getCommentById(int id)
        {
            return commentRepository.getById(id);
        }

        public IEnumerable<Comment> getCommentByPost(int id)
        {
            return commentRepository.getByPost(id);
        }

        public void createComment(Comment comment)
        {
            commentRepository.create(comment);

        }

        public void updateComment(int id, Comment comment)
        {
            commentRepository.update(id, comment);
        }

        public void deleteComment(int id)
        {
            commentRepository.delete(id);
        }
    }
}
