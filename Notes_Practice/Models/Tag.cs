using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes_Practice.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string TagName { get; set; }
        public ICollection<TaggedNote> TaggedNotes { get; set; }

    }
}
