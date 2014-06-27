using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneAppHackathon.Models
{
    public class Comment
    {
        public virtual int Id { get; set; }
        public virtual string Body { get; set; }
        public virtual User User { get; set; }
        public virtual Ticket Ticket { get; set; }
        public virtual DateTime CreatedAt { get; set; }
        public virtual int TicketId { get; set; }
    }
}
