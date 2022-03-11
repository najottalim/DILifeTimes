using DILifeTimes.Models;
using System.Collections.Generic;

namespace DILifeTimes.Service
{
    public class UserService : IUserService
    {
        private IList<UserModel> _users;
        public UserService()
        {
            _users = new List<UserModel>()
            {
                new UserModel { Id = 1, Name = "Muhammadkarim" },
                new UserModel { Id = 2, Name = "Ahmadjon" },
                new UserModel { Id = 3, Name = "Muhammadmin" }
            };
        }
        public UserModel Create(UserModel user)
        {
            _users.Add(user);
            return user;
        }

        public IEnumerable<UserModel> GetAll()
        {
            return _users;
        }
    }
}
