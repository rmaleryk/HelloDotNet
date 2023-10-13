using System.Collections.Generic;
using HelloWebApi.Models;

namespace HelloWebApi.Interfaces
{
    public interface IUserService
    {
        List<User> GetUsers();
    }
}
