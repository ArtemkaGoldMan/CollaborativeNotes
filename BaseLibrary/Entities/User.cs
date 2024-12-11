using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public class User
    {
        public int Id { get; set; } // Unique identifier for persistence
        public string Username { get; set; } // Username for identification
        public string ConnectionId { get; set; } // SignalR connection ID
        public ICollection<UserNote> UserNotes { get; set; } = new List<UserNote>();
    }
}
