using Applications.Interfaces.BankInterface;
using Applications.Request;
using System;
using System.Threading.Tasks;

namespace Applications.Services.UserInterface
{
    internal class UserService : IUserInteface
    {
        public Task CreateUSer(UsersRequest request)
        {
            throw new NotImplementedException();
        }

        public Task GetUserById(int id, string name)
        {
            throw new NotImplementedException();
        }

        public Task GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateInfoUser(UsersRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
