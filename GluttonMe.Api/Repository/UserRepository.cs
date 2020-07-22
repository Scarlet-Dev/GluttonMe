using GluttonMe.Api.Interfaces;
using GluttonMe.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GluttonMe.Api.Repository
{
    public class UserRepository : IUserRepository<User>
    {
        public User Create(User model)
        {
            throw new NotImplementedException();
        }

        public List<User> Get()
        {
            throw new NotImplementedException();
        }

        public List<User> Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(User model)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, User model)
        {
            throw new NotImplementedException();
        }
    }
}
