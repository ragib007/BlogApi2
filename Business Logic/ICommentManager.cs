using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApi2.Models;

namespace BlogApi2.Business_Logic
{
    public interface ICommentManager 
    {
        List<Comment> getAllComments();

        Comment getCommentById(int id);

        IEnumerable<Comment> getCommentByPost(int id);

        void createComment(Comment comment);

        void updateComment(int id, Comment comment);

        void deleteComment(int id);





    }
}
