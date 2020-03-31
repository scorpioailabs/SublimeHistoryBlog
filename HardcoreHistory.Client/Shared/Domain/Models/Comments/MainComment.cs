using System;
using System.Collections.Generic;
using System.Text;

namespace HardcoreHistory.Client.Shared.Domain
{
    public class MainComment : Comment
    {
        public List<SubComment> SubComments { get; set; }
        public string UserId { get; internal set; }
        public int PostId { get; set; }
    }
}
