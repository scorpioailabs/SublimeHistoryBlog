using HardcoreHistory.Client.Shared.Domain;
using HardcoreHistory.Client.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace HardcoreHistory.Client.Interfaces
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
