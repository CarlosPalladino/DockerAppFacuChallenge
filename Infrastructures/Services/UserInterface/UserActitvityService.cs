using Applications.Interfaces.UserInterface;
using Applications.Request.UserRequest;
using System;
using System.Threading.Tasks;

namespace Applications.Services.UserInterface
{
    public class UserActitvityService : IuserActivityInterface
    {
        public Task GetAllUserActivity(UserActivityRequest request)
        {
            throw new NotImplementedException();
        }

        public Task GetUserActivityByStatus(string status)
        {
            throw new NotImplementedException();
        }
    }
}
