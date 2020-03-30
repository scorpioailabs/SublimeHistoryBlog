using System;
using System.Collections.Generic;
using System.Text;

namespace HardcoreHistoryBlog.Domain.Domain.Models
{
    public class PostLike : Like
    {
        public int PostId { get; set; }
    }
}
