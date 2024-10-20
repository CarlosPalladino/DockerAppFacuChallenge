using System;

namespace Core.Entities
{
    public class MessageLog
    {
        public Guid Id { get; set; }
        public string QueueName { get; set; }
        public string MessageContent { get; set; }
        public DateTime ProcessedAt { get; set; }
        public string Status { get; set; } // Procesado, fallido, etc.


        public virtual Message Message { get; set; }
        public virtual User User { get; set; }

    }

}
