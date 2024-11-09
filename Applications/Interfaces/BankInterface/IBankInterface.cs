using Applications.Request.BankRequests;
using System.Threading.Tasks;

namespace Applications.Interfaces.BankInterface
{
    public interface IBankInterface
    {
        Task GetAllAccount();
        Task GetAccountByName(BankAccountRequest request);
        Task CreateBankAccount();
        Task DeleteAccount(int Id);

    }
}
