using System;
using System.Collections.Generic;
using System.Text;

namespace HardcoreHistory.Client.Shared.Domain
{
    public class PostLike : Like
    {
        public int PostId { get; set; }
    }
}
