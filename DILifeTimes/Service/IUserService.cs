using DILifeTimes.Models;
using System.Collections.Generic;

namespace DILifeTimes.Service
{
    public interface IUserService
    {
        IEnumerable<UserModel> GetAll();
        UserModel Create(UserModel user);
    }
}
