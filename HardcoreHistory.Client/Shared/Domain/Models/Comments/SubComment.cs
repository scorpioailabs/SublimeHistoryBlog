using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HardcoreHistory.Client.Shared.Domain
{
    public class SubComment : Comment
    {
        [Required]
        public int MainCommentId { get; set; }  //1-many relationship with maincomment
        public string UserId { get; internal set; }
    }
}
