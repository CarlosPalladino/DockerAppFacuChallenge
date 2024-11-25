using Applications.Request;
using System.Threading.Tasks;

namespace Applications.Interfaces.BankInterface
{
    public interface IUserInteface
    {
        Task GetUsers();
        Task GetUserByName(string name);

        Task CreateUSer(UsersRequest request);
        Task UpdateInfoUser(UsersRequest request);
        Task SoftDeleteUser(int id);
    }
}
