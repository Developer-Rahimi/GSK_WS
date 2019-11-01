using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wherapp_gsk.Models
{
  
    public class Comment
    {
        public int id { get; set; }
        public  User User { get; set; }
        public int UserID { get; set; }
        public string CommentSubject { get; set; }
        public string CommentDesc { get; set; }
        public Decimal CommentRating { get; set; }
        public Content Content { get; set; }
        public long ContentID { get; set; }
        public DateTime CommentCreateAt { get; set; }

    }
}