using HardcoreHistory.Client.Shared;
using HardcoreHistory.Client.Shared.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HardcoreHistory.Client.Interfaces.Base
{
    public interface IBaseRepository<T>
    {
        Task<T> GetAsync(int Id);
        Task<PagedQueryResult<T>> PagedQueryAsync(IQuerySpecification<T> specification);
        Task<List<T>> QueryAsync(IQuerySpecification<T> specification);
        Task<bool> SaveChangesAsync();
        void Add(T item);
    }
}
