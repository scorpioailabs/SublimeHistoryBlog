using AutoMapper;
using HardcoreHistory.Client.Shared.Domain;
using HardcoreHistory.Client.Interfaces.Base;
using HardcoreHistory.Infrastructure.Context;
using HardcoreHistory.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HardcoreHistory.Client.Shared.Common;
using HardcoreHistory.Client.Interfaces;

namespace HardcoreHistory.Infrastructure.Repositories
{
    public class CommentRepository : EntityBaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(ApplicationDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public void AddSubComment(SubComment comment)
        {
            throw new NotImplementedException();
        }

        public Task<PagedQueryResult<Comment>> PagedQueryAsync(IQuerySpecification<Comment> specification)
        {
            throw new NotImplementedException();
        }

        public Task<List<Comment>> QueryAsync(IQuerySpecification<Comment> specification)
        {
            throw new NotImplementedException();
        }

        public void RemoveComment(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
