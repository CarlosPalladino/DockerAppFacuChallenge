﻿using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegisteredAt { get; set; }

        // Relación con BankAccounts
        public virtual ICollection<BankAccount> BankAccounts { get; set; }

        // Otras propiedades de navegación
        public virtual ICollection<UserActivity> UserActivities { get; set; }
        public virtual ICollection<MessageLog> MessageLogs { get; set; }
    }



}
