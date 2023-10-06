using System.Collections.Generic;
using HelloDotNet.Interfaces;
using HelloDotNet.Models;

namespace HelloDotNet.Services
{
    public class UserService : IUserService
    {
        public ResponseModel<User> GetUsers()
        {
            // Real call
            return new ResponseModel<User>
            {
                Data = new List<User>
                {
                    new User
                    {
                        Id = 1,
                        Name = "Super admin",
                        Email = "email@gmail.com"
                    }
                },
                TotalCount = 10
            };
        }
    }
}
