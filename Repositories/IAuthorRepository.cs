using BlogApi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApi2.Repositories
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> getAll();

        Author getById(int id);

        IEnumerable<Post> getPosts(string name);

        IEnumerable<Comment> getComments(Author author);

        void create(Author author);

        void update(int id, Author author);

        void delete(int id);
    }
}
