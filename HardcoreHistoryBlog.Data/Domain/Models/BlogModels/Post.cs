using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HardcoreHistoryBlog.Domain.Domain.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public virtual string Title { get; set; } = "";
        public virtual string Short_Description { get; set; }
        public string Image { get; set; } = "";

        [DataType(DataType.MultilineText)]
        public virtual string Content { get; set; } = "";

        public string Category { get; set; } = "";
        public string Tags { get; set; } = "";

        public DateTime Posted { get; set; } = DateTime.Now;
        public DateTime? Modified { get; set; } = DateTime.Now;
        public virtual ApplicationUser User { get; set; }
        public List<MainComment> MainComments { get; set; }
        public string UserId { get; set; }
    }
}
