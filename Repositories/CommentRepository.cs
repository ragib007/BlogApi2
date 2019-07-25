using BlogApi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApi2.Repositories
{
    public class CommentRepository : ICommentRepository
    {

        public List<Comment> comments = new List<Comment>();

        public CommentRepository()
        {
            comments.Add(new Comment { Id = 1, Text = "Please explain the model state in the database", author = new Author { Id = 2, Name = "Jon Nash", Email = "jon-nash@gmail.com", Articles = 12 }, post=new Post { Id = 1, Title = "Model", Text = "These are objects that fetch the model state in the database", CreatedAt = new DateTime(2019, 7, 2, 11, 45, 13), author = new Author { Id = 1, Name = "Jon Snow", Email = "jon-snow@gmail.com", Articles = 11 } }, CreatedAt = new DateTime(2019, 7, 2, 11, 45, 13) });
            comments.Add(new Comment { Id = 2, Text = "How can the developers ‘view’ the UI or User Interface of the applications created by data model?", author = new Author { Id = 2, Name = "Jon Nash", Email = "jon-nash@gmail.com", Articles = 12 }, post=new Post { Id = 2, Title = "View", Text = "Here, the developers can ‘view’ the UI or User Interface of the applications created by data model.", CreatedAt = new DateTime(2019, 7, 4, 12, 53, 35), author = new Author { Id = 1, Name = "Jon Snow", Email = "jon-snow@gmail.com", Articles = 11 } },CreatedAt = new DateTime(2019, 7, 4, 12, 53, 35)  });
            comments.Add(new Comment { Id = 3, Text = "Is it Controller or Component which manages the user interaction?", author = new Author { Id = 1, Name = "Jon Snow", Email = "jon-snow@gmail.com", Articles = 11 }, post=new Post { Id = 3, Title = "Controllers", Text = "Controllers or Components manage the user interaction", CreatedAt = new DateTime(2019, 7, 9, 7, 24, 11), author = new Author { Id = 2, Name = "Jon Nash", Email = "jon-nash@gmail.com", Articles = 12 } }, CreatedAt = new DateTime(2019, 7, 9, 7, 24, 11)});
            comments.Add(new Comment { Id = 4, Text = "How does Controller manage the user interaction?", author = new Author { Id = 1, Name = "Jon Snow", Email = "jon-snow@gmail.com", Articles = 11 }, post = new Post { Id = 3, Title = "Controllers", Text = "Controllers or Components manage the user interaction", CreatedAt = new DateTime(2019, 7, 9, 7, 24, 11), author = new Author { Id = 2, Name = "Jon Nash", Email = "jon-nash@gmail.com", Articles = 12 } }, CreatedAt = new DateTime(2019, 7, 9, 7, 24, 11) });

        }

        public List<Comment> getAll()
        {
            return comments;
        }

        public Comment getById(int id)
        {
            var comment = comments.FirstOrDefault(p => p.Id == id);
            return comment;
        }

        public IEnumerable<Comment> getByPost(int id)
        {
            return comments.Where(p => Equals(p.post.Id, id));
        }

        public void create(Comment comment)
        {
            comments.Add(comment);
        }

        public void update(int id, Comment comment)
        {
            var index = comments.FindIndex(p => p.Id == id);
            comments[index] = comment;
        }


        public void delete(int id)
        {
            var index = comments.FindIndex(p => p.Id == id);
            comments.RemoveAt(index);
        }
    }
}
