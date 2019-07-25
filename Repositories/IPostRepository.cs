using BlogApi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApi2.Repositories
{
    public interface IPostRepository
    {

        List<Post> getAll();

        Post getById(int id);

        IEnumerable<Post> getByAuthor(string name);

        IEnumerable<string> getTitle();

        void create(Post post);

        void update(int id,Post post);

        void delete(int id);

    }
}
