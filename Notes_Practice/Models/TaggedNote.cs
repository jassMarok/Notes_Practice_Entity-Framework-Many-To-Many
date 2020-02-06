using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes_Practice.Models
{
    public class TaggedNote
    {
        public int TagId { get; set; }
        public Tag Tag { get; set; }
        public int NoteId { get; set; }
        public Note Note { get; set; }
    }
}
