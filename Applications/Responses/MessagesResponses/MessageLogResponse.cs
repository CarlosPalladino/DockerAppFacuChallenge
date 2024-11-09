using System;

namespace Applications.Responses.MessagesResponses
{
    public class MessageLogResponse
    {
        public string QueueName { get; set; }
        public string MessageContent { get; set; }
        public string Status { get; set; }
        public Guid MessageId { get; set; }


    }
}
