using Applications.Interfaces.BankInterface;
using Applications.Request.BankRequests;
using System;
using System.Threading.Tasks;

namespace Applications.Services.BankService
{
    public class BankService : IBankInterface
    {
        public Task CreateBankAccount()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAccount(int Id)
        {
            throw new NotImplementedException();
        }

        public Task GetAccountByName(BankAccountRequest request)
        {
            throw new NotImplementedException();
        }

        public Task GetAllAccount()
        {
            throw new NotImplementedException();
        }
    }
}
