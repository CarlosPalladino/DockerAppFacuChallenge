using Applications.Request.UserRequest;
using System.Threading.Tasks;

namespace Applications.Interfaces.UserInterface
{
    public interface IuserActivityInterface
    {
        Task GetAllUserActivity(UserActivityRequest request);
        Task GetUserActivityByStatus(string status);

    }
}
