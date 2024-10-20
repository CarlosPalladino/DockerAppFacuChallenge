using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public decimal Amount { get; set; }
        public string TransactionType { get; set; } // Ej: "Deposit", "Withdrawal", "Transfer", etc.
        public DateTime TransactionDate { get; set; }
        public string Status { get; set; } // Ej: Completed, Pending, Failed, etc.

        public virtual BankAccount BankAccount { get; set; }
        public virtual User User { get; set; }
    }

}
