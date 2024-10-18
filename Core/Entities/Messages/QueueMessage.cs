using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class QueueMessage : Message
    {
        public DateTime SentAt { get; set; }
        public string QuueMessage { get; set; }
    }
}
