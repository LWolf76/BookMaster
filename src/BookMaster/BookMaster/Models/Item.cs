using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookMaster.Models
{
    public class Item
    {
        public Int32 ItemId { get; set; }
        public Int32 Type { get; set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public String PersonalAuthor { get; set; }
        public String ISBN { get; set; }
        public String Publisher { get; set; }
        public Int32 Published { get; set; }
        public String Edition { get; set; }
        public String PublicationInformation { get; set; }
        public Int32 Pages { get; set; }
        public String Location { get; set; }
        public String Summary { get; set; }


        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<ItemContent> ItemContents { get; set; }

    }
}