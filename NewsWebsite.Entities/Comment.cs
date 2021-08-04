using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewsWebsite.Entities
{
   public class Comment
    {
        [Key]
        public string CommentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Descriotion { get; set; }
        public string NewsId { get; set; }
        public bool IsConfirm { get; set; }
        public DateTime? PostageDateTime { get; set; }

        public string ParentCommentId { get; set; }
        public virtual Comment comment { get; set; }
        public virtual News News { get; set; }



    }
}
