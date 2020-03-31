using HardcoreHistory.Client.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HardcoreHistory.Client.Shared.Domain
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
