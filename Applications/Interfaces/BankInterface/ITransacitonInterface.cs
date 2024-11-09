using Applications.Request.BankRequests;
using System.Threading.Tasks;

namespace Applications.Interfaces.BankInterface
{
    public interface ITransacitonInterface
    {
        Task CreateTransaction();
        Task GetTransactions();

        Task GetPeriodOfTransaction(TransactionRequest request);
    }
}
