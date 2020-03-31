using HardcoreHistory.Client.Interfaces;
using HardcoreHistory.Client.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HardcoreHistory.Client.Shared.Specifications.Base
{
    public abstract class BaseQuerySpecification
    {
        public SortOrder SortOrder { get; set; }
        public int? Skip { get; set; }
        public int? Take { get; set; }
        public bool PerformCount { get; set; }
        public bool DisableTracking { get; set; }

        public List<string> StringIncludes { get; set; } = new List<string>();

        public bool PerformPagination
        {
            get
            {
                return ((Take.HasValue && Take.Value > 0) && (Skip.HasValue && Skip.Value > 0));
            }
        }
    }
}
