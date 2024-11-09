using Applications.Interfaces.BankInterface;
using Applications.Request.BankRequests;
using System;
using System.Threading.Tasks;

namespace Applications.Services.BankService
{
    public class TransactionService : ITransacitonInterface
    {
        public Task CreateTransaction()
        {
            throw new NotImplementedException();
        }

        public Task GetPeriodOfTransaction(TransactionRequest request)
        {
            throw new NotImplementedException();
        }

        public Task GetTransactions()
        {
            throw new NotImplementedException();
        }
    }
}
