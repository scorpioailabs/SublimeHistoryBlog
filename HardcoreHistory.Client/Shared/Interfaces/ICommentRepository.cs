using HardcoreHistory.Client.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HardcoreHistory.Client.Interfaces.Base
{
    public interface ICommentRepository : IBaseRepository<Comment>
    {
        void AddSubComment(SubComment comment);
        void RemoveComment(int id);
    }
}
