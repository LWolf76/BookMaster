using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.DTO
{
    class BookChapter
    {
        public Int32 BookChapterId { get; set; }
        public String Description { get; set; }
        public Int32 Subject { get; set; }
        
        public Int32 BookId { get; set; }
    }
}
