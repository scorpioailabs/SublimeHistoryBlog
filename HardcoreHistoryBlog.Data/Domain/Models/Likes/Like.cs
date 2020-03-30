using System;
using System.Collections.Generic;
using System.Text;

namespace HardcoreHistoryBlog.Domain.Domain.Models
{
    public class Like
    {
        public int Id { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
