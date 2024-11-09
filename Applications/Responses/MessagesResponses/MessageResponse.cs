using System;

namespace Applications.Responses.MessagesResponses
{
    public class MessageResponse
    {
        public string Content { get; set; }
        public string MessageType { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
