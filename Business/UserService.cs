using Common;
using Entities;
using Entities.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class UserService : IUserService
    {
        private ProductContext _context;
        public UserService(ProductContext context)
        {
            _context = context;
        }
        public User Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public void Delete(Guid id)
        {
            // stergere pe baza id-ului
        }

        public IEnumerable<UserDetailDTO> GetAll()
        {
            return _context.Users.Include(o => o.Orders).Select(
                item => new UserDetailDTO
                {
                    Id = item.Id,
                    FirstName = item.FirstName,

                    LastName = item.LastName
                });
        }
    }
}