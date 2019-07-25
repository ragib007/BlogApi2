using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApi2.Models;

namespace BlogApi2.Repositories
{
    public class PostRepository : IPostRepository
    {

        public List<Post> posts = new List<Post>();

        public PostRepository()
        {
            posts.Add(new Post { Id = 1, Title = "Model", Text = "These are objects that fetch the model state in the database", CreatedAt = new DateTime(2019, 7, 2, 11, 45, 13), author = new Author { Id = 1, Name = "Jon Snow", Email = "jon-snow@gmail.com", Articles = 11 } });
            posts.Add(new Post { Id = 2, Title = "View", Text = "Here, the developers can ‘view’ the UI or User Interface of the applications created by data model.", CreatedAt = new DateTime(2019, 7, 4, 12, 53, 35), author = new Author { Id = 1, Name = "Jon Snow", Email = "jon-snow@gmail.com", Articles = 11 } });
            posts.Add(new Post { Id = 3, Title = "Controllers", Text = "Controllers or Components manage the user interaction", CreatedAt = new DateTime(2019, 7, 9, 7, 24, 11), author = new Author { Id = 2, Name = "Jon Nash", Email = "jon-nash@gmail.com", Articles = 12 } });

        }

        public List<Post> getAll()
        {
            return posts;
        }

        public Post getById(int id)
        {
            var post = posts.FirstOrDefault(p => p.Id == id);
            return post;
            
        }

        public IEnumerable<Post> getByAuthor(string name)
        {
            return posts.Where(p=>string.Equals(p.author.Name,name));
        }

        public IEnumerable<string> getTitle()
        {
            List<string> titles = new List<string>();
            foreach (var post in posts)
                titles.Add(post.Title);
            return titles;
        }

        public void create(Post post)
        {
            posts.Add(post);
        }

        public void update(int id,Post post)
        {
            var index = posts.FindIndex(p=>p.Id==id);
            posts[index] = post;
        }

        public void delete(int id)
        {
            var index = posts.FindIndex(p => p.Id == id);
            posts.RemoveAt(index);
        }

    }
}
