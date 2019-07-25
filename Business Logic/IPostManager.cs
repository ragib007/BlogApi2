using BlogApi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApi2.Business_Logic
{
    public interface IPostManager
    {

        List<Post> getAllPosts();

        Post getPostById(int id);

        IEnumerable<Post> getPostByAuthor(string name);

        IEnumerable<string> getPostTitle();

        void createPost(Post post);

        void updatePost(int id,Post post);

        void deletePost(int id);

    }
}
