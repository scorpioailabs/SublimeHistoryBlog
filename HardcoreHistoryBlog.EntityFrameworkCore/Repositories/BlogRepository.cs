using AutoMapper;
using HardcoreHistory.Client.Shared.Domain;
using HardcoreHistory.Client.Interfaces;
using HardcoreHistory.Infrastructure.Context;
using HardcoreHistory.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HardcoreHistory.Client.Shared.Common;

namespace HardcoreHistory.Infrastructure.Repositories
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

        public Task<PagedQueryResult<Post>> PagedQueryAsync(IQuerySpecification<Post> specification)
        {
            throw new NotImplementedException();
        }

        public Task<List<Post>> QueryAsync(IQuerySpecification<Post> specification)
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
