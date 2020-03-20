using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestVocalcom.Models;
using X.PagedList;

namespace TestVocalcom.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UsersContext _usersContext;
        public UserRepository(UsersContext usersContext)
        {
            _usersContext = usersContext;
        }
        public async Task AddUser(User user)
        {
            _usersContext.User.Add(user);
            await _usersContext.SaveChangesAsync();
        }
        public async Task<User> GetUserById(int id)
        {
            return await _usersContext.User
                .FirstOrDefaultAsync(u => u.Id == id);
        }
        public async Task<IPagedList<User>> GetUsers(int? page, string search)
        {
            int pageSize = 2;
            var users = from u in _usersContext.User
                            select u;
            if (!String.IsNullOrEmpty(search))
            {
                users = users.
                    Where(s => s.Username.Contains(search));
            }

            return await users.ToPagedListAsync(page ?? 1, pageSize);
        }
        public async Task UpdateUser(User user)
        {
           _usersContext.Entry(user).State = EntityState.Modified;
           await _usersContext.SaveChangesAsync();
        }
    }
}
