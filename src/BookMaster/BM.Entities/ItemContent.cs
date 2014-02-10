using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Entities
{
    class ItemContent
    {
        public Int32 ItemContentId { get; set; }
        public String Description { get; set; }
        public Int32 Subject { get; set; }

        public Int32 ItemId { get; set; }
    }
}
