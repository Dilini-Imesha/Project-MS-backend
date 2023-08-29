using Microsoft.EntityFrameworkCore;
using project_management_system_backend.Data;
using project_management_system_backend.Models;

namespace project_management_system_backend.Repostories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApiDbContext _dbContext;

        public UserRepository(ApiDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<List<User>> GetAllUsers()
        {
            var users = _dbContext.users.ToList();

            return users;
        }

        public async Task<User> GetUserByID(int id)
        {
            var user = _dbContext.users.Find(id);

            return user;
        }

        public async Task<User> CreatUser(User newUser)
        {
            var user = _dbContext.users.Find(newUser.Id);

            if (user != null)
                return null;

            _dbContext.users.Add(newUser);
            _dbContext.SaveChanges();

            return _dbContext.users.Where(user => 
                user.UserName == newUser.UserName
            ).FirstOrDefault();
        }

        public Task<User> UpdateUser(User newUser)
        {
            throw new NotImplementedException();
        }
    }
}
