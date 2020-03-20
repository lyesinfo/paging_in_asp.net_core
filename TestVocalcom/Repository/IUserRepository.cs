using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestVocalcom.Models;
using X.PagedList;

namespace TestVocalcom.Repository
{
    public interface IUserRepository
    {
        Task<IPagedList<User>> GetUsers(int? page, string search);
        Task<User> GetUserById(int id);
        Task AddUser(User user);
        Task UpdateUser(User user);
    }
}
