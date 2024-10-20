using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class BankAccount
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string AccountType { get; set; } 
        public DateTime CreatedAt { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }

}
