using System;

namespace Core.Entities
{
    public class QueueMessage
    {
        public Guid Id { get; set; }
        public Guid MessageId { get; set; }
        public DateTime SentAt { get; set; }
        public string QuueMessage { get; set; }
        public virtual Message Message { get; set; }

    }
}
