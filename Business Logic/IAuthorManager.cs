using BlogApi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApi2.Business_Logic
{
    public interface IAuthorManager
    {
        IEnumerable<Author> getAllAuthors();

        Author getAuthorById(int id);

        IEnumerable<Post> getAuthorPosts(string name);

        void createAuthor(Author author);

        void updateAuthor(int id, Author author);

        void deleteAuthor(int id);

    }
}
