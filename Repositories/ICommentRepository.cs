using BlogApi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApi2.Repositories
{
    public interface ICommentRepository
    {
        List<Comment> getAll();

        Comment getById(int id);

        IEnumerable<Comment> getByPost(int id);

        void create(Comment comment);

        void update(int id, Comment comment);

        void delete(int id);

    }
}
