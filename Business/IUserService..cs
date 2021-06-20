using Common;
using Entities;
using System;
using System.Collections.Generic;

namespace Business
{
    public interface IUserService
    {
        User Create(User user);
        IEnumerable<UserDetailDTO> GetAll();
        void Delete(Guid id);
    }
}
