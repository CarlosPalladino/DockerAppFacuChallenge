using System;

namespace Core.Entities
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public string TransactionType { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Status { get; set; }
        public Guid BankAccountId { get; set; }
        public virtual BankAccount BankAccount { get; set; }
    }


}
