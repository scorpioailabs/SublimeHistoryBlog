using HardcoreHistoryBlog.Domain.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HardcoreHistoryBlog.Domain.Domain.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public virtual ApplicationUser User { get; set; }
        public string By { get; set; }
        public virtual Post Post { get; set; }
    }
}
