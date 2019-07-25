using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApi2.Models;
using BlogApi2.Repositories;

namespace BlogApi2.Business_Logic
{
    public class AuthorManager : IAuthorManager
    {
        IAuthorRepository authorRepository = new AuthorRepository();

        public IEnumerable<Author> getAllAuthors()
        {
            return authorRepository.getAll();
        }

        public Author getAuthorById(int id)
        {
            return authorRepository.getById(id);
        }

        public IEnumerable<Post> getAuthorPosts(string name)
        {
            return authorRepository.getPosts(name);
        }

        public void createAuthor(Author author)
        {
            authorRepository.create(author);
        }

        public void updateAuthor(int id,Author author)
        {
            authorRepository.update(id, author);
        }

        public void deleteAuthor(int id)
        {
            authorRepository.delete(id);
        }

    }
}
