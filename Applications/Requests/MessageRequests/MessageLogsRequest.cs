using System;

namespace Applications.Request.MessageRequests
{
    public class MessageLogsRequest
    {
        public string QueueName { get; set; }
        public string MessageContent { get; set; }
        public DateTime ProcessedAt { get; set; }
        public string Status { get; set; }
        public Guid MessageId { get; set; }
    }
}
