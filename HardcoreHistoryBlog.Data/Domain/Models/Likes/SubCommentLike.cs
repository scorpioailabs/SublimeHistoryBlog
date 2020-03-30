using System;
using System.Collections.Generic;
using System.Text;

namespace HardcoreHistoryBlog.Domain.Domain.Models
{
    public class SubcommentLike : Like
    {
        public int SubcommentId { get; set; }
    }
}
