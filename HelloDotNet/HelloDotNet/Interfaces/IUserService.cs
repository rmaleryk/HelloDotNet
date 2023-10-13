using HelloDotNet.Models;

namespace HelloDotNet.Interfaces
{
    public interface IUserService
    {
        ResponseModel<User> GetUsers();
    }
}
