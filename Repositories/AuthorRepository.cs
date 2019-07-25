using BlogApi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApi2.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        public List<Author> authors = new List<Author>();
        public AuthorRepository()
        {
            authors.Add(new Author { Id = 1, Name = "Jon Snow", Email = "jon-snow@gmail.com", Articles = 11 });
            authors.Add(new Author { Id = 2, Name = "Jon Nash", Email = "jon-nash@gmail.com", Articles = 12 });
        }

        public IEnumerable<Author> getAll()
        {
            return authors;
        }

        public Author getById(int id)
        {
            Author author = authors.FirstOrDefault(p=>p.Id==id);
            return author;
        }

        public IEnumerable<Post> getPosts(string name)
        {
            PostRepository postRepository = new PostRepository();
            return postRepository.posts.Where(p=>p.author.Name==name);
        }

        public IEnumerable<Comment> getComments(Author author)
        {
            CommentRepository commentRepository = new CommentRepository();
            return commentRepository.comments.Where(p => p.author.Name == author.Name);
        }

        public void create(Author author)
        {
            authors.Add(author);
        }

        public void update(int id,Author author)
        {
            var index = authors.FindIndex(p => p.Id == id);
            authors[index] = author;
        }

        public void delete(int id)
        {
            var index = authors.FindIndex(p => p.Id == id);
            authors.RemoveAt(index);
        }
    }
}
