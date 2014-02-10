using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.DTO
{
    public class Book
    {
        public Int32 BookId { get; set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public String PersonalAuthor { get; set; }
        public String ISBN { get; set; }
        public String Publisher { get; set; }
        public Int32 Published { get; set; }
        public String Edition { get; set; }
        public String PublicationInformation { get; set; }
        public Int32 Pages { get; set; }
        public Int32 Subject { get; set; }
        public String Location { get; set; }
        public String Summary { get; set; }
    }
}
