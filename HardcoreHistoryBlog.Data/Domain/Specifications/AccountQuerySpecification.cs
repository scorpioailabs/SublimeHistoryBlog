using HardcoreHistoryBlog.Domain.Domain.Models;
using HardcoreHistoryBlog.Domain.Domain.Specifications.Base;
using HardcoreHistoryBlog.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace HardcoreHistoryBlog.Domain.Domain.Specifications
{
    public class AccountQuerySpecification : BaseQuerySpecification, IQuerySpecification<ApplicationUser>
    {
        public Expression<Func<ApplicationUser, bool>> WhereClause { get; set; }
        public List<Expression<Func<ApplicationUser, object>>> Includes { get; set; } = new List<Expression<Func<ApplicationUser, object>>>();
        public Expression<Func<ApplicationUser, dynamic>> OrderBy { get; set; }
        SortOrder IQuerySpecification<ApplicationUser>.SortOrder { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
