using System;
using System.Collections.Generic;
using System.Text;

namespace HardcoreHistory.Client.Shared.Common
{
    public class PagedQueryResult<T>
    {
        public PagedQueryResult(List<T> items, int? totalCount)
        {
            Items = items;
            TotalCount = totalCount;
        }

        public List<T> Items { get; set; }
        public int? TotalCount { get; set; }
    }
}
