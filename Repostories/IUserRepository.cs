using project_management_system_backend.Models;

namespace project_management_system_backend.Repostories
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetUserByID(int id);
        Task<User> CreatUser(User newUser);
        Task<User> UpdateUser(User newUser);
    }
}
