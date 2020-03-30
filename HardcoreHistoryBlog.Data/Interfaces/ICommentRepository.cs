using HardcoreHistoryBlog.Domain.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HardcoreHistoryBlog.Domain.Interfaces.Base
{
    public interface ICommentRepository : IBaseRepository<Comment>
    {
        void AddSubComment(SubComment comment);
        void RemoveComment(int id);
    }
}
