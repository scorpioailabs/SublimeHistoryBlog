using System;
using System.Collections.Generic;
using System.Text;

namespace HardcoreHistoryBlog.Domain.Domain.Models
{
    public class MainCommentLike : Like
    {
        public int MainCommentId { get; set; }
    }
}
