﻿using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Message
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public string MessageType { get; set; } // Ej: TransactionCreated, UserRegistered, etc.
        public string Status { get; set; } // Pending, Sent, Failed, etc.
        public virtual ICollection<MessageLog> MessageLogs { get; set; }
    }

}
