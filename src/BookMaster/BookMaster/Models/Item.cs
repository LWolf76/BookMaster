using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookMaster.Models
{
    public enum ItemType
    {
        Book,
        DVD,
        CD
    }

    public class Item
    {
        public Int32 ItemId { get; set; }

        [Display(Name = "Type")]
        [Required(ErrorMessage = "Type Required")]
        public ItemType? ItemType { get; set; }

        [Required(ErrorMessage = "Title Required")]
        public String Title { get; set; }

        public String Author { get; set; }
        public String ISBN { get; set; }
        public String Publisher { get; set; }
        public Int32 Published { get; set; }
        public String Edition { get; set; }
        public String PublicationInformation { get; set; }
        public Int32 Pages { get; set; }
        public String Location { get; set; }
        public String Summary { get; set; }
        
        [Display(Name = "Subjects")]
        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<ItemContent> ItemContents { get; set; }

    }
}