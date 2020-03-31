using HardcoreHistory.Client.Shared.Domain;
using HardcoreHistory.Client.Shared.Specifications.Base;
using HardcoreHistory.Client.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace HardcoreHistory.Client.Shared.Specifications
{
    public class AccountQuerySpecification : BaseQuerySpecification, IQuerySpecification<ApplicationUser>
    {
        public Expression<Func<ApplicationUser, bool>> WhereClause { get; set; }
        public List<Expression<Func<ApplicationUser, object>>> Includes { get; set; } = new List<Expression<Func<ApplicationUser, object>>>();
        public Expression<Func<ApplicationUser, dynamic>> OrderBy { get; set; }
        SortOrder IQuerySpecification<ApplicationUser>.SortOrder { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
