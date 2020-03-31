using System;
using System.Collections.Generic;
using System.Text;

namespace HardcoreHistory.Client.Shared.Domain
{
    public class SubcommentLike : Like
    {
        public int SubcommentId { get; set; }
    }
}
