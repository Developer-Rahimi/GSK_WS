using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using Antlr.Runtime.Tree;

namespace wherapp_gsk.Models
{
    public class Content
    {
        public long ContentID { get; set; }
        public virtual User User { get; set; }
        public int UserID { get; set; }
        public string ContentName  { get; set; }
        public DateTime ContentCreateAt { get; set; }
        public string ContentDateFa { get; set; }
        public virtual ContentType ContentType { get; set; }
        public int ContentTypeID  { get; set; }
        public virtual ContentStatus ContentStatus { get; set; }
        public int  ContentStatusID { get; set; }
        public ICollection<Image> Images { get; set; }
        public ICollection<Introduction> Introductions { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Specification> Specifications { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public DateTime ContentUpdateAt { get; set; }
    }
    
}