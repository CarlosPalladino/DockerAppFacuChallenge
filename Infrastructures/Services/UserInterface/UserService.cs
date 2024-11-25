using Applications.Interfaces.BankInterface;
using Applications.Request;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;


namespace Applications.Services.UserInterface
{

    public class UserService : IUserInteface
    {
        private ApplicationDbContext _context;


        public UserService(ApplicationDbContext context)
        {
            context = _context;
        }
        public Task CreateUSer(UsersRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task GetUserByName(string name)
        {
            var asd = await _context.Users
                .Where(us => us.Name.Equals(name))
                .FirstOrDefaultAsync();

            //return asd;
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
