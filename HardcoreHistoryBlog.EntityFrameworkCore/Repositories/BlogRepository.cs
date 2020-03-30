using AutoMapper;
using HardcoreHistoryBlog.Domain.Domain.Models;
using HardcoreHistoryBlog.Domain.Interfaces;
using HardcoreHistoryBlog.Infrastructure.Context;
using HardcoreHistoryBlog.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HardcoreHistoryBlog.Infrastructure.Repositories
{
    public class BlogRepository : EntityBaseRepository<Post>, IBlogRepository
    {
        public BlogRepository(ApplicationDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public void AddPost(Post post)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetAllPosts()
        {
            throw new NotImplementedException();
        }

        public List<Post> GetAllPosts(string Category)
        {
            throw new NotImplementedException();
        }

        public Post GetPost(int id)
        {
            throw new NotImplementedException();
        }

        public void RemovePost(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void UpdatePost(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
