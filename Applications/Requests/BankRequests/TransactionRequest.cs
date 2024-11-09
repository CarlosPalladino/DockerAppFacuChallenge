using System;

namespace Applications.Request.BankRequests
{
    public class TransactionRequest
    {
        public decimal Amount { get; set; }
        public string TransactionType { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
