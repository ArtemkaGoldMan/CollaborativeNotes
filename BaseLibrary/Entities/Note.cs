using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime LastModified { get; set; }
        public string LastModifiedBy { get; set; } // Username of the last editor
        public ICollection<UserNote> UserNotes { get; set; } = new List<UserNote>();
    }
}
