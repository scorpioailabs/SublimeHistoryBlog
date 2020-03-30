using AutoMapper;
using HardcoreHistoryBlog.Domain.Domain.Models;
using HardcoreHistoryBlog.Domain.Interfaces.Base;
using HardcoreHistoryBlog.Infrastructure.Context;
using HardcoreHistoryBlog.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HardcoreHistoryBlog.Infrastructure.Repositories
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
