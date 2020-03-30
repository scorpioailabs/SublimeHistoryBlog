using HardcoreHistoryBlog.Domain.Domain.Models;
using HardcoreHistoryBlog.Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace HardcoreHistoryBlog.Domain.Interfaces
{
    public interface IBlogRepository : IBaseRepository<Post>
    {
        Post GetPost(int id);
        List<Post> GetAllPosts();
        List<Post> GetAllPosts(string Category);

        void AddPost(Post post);
        void UpdatePost(Post post);
        void RemovePost(int id);
    }
}
