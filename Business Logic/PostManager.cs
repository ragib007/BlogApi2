using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApi2.Repositories;
using BlogApi2.Models;

namespace BlogApi2.Business_Logic
{
    public class PostManager : IPostManager
    {

        IPostRepository postRepository = new PostRepository();

        public List<Post> getAllPosts()
        {
            return postRepository.getAll();
        }
        
        public Post getPostById(int id)
        {
            return postRepository.getById(id);
        }

        public IEnumerable<Post> getPostByAuthor(string name)
        {
            return postRepository.getByAuthor(name);
        }

        public IEnumerable<string> getPostTitle()
        {
            return postRepository.getTitle();
        }

        public void createPost(Post post)
        {
            postRepository.create(post);
            
        }

        public void updatePost(int id,Post post)
        {
            postRepository.update(id,post);
        }

        public void deletePost(int id)
        {
            postRepository.delete(id);
        }

    }
}
