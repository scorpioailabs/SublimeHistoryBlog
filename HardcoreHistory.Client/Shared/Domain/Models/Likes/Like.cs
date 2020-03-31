using System;
using System.Collections.Generic;
using System.Text;

namespace HardcoreHistory.Client.Shared.Domain
{
    public class Like
    {
        public int Id { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
