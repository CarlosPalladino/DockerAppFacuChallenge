using System;

namespace Core.Entities
{
    public record MessageLog
    {
        public Guid Id { get; init; }
        public string QueueName { get; init; }
        public string MessageContent { get; init; }
        public DateTime ProcessedAt { get; init; }
        public string Status { get; init; }
        public Guid MessageId { get; init; }
        public Guid UserId { get; init; }
        public Message Message { get; init; }
        public User User { get; init; }


    }
}