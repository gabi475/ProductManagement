using Entities;
using System;
using System.Collections.Generic;

namespace Business
{
    public interface ICompanyService
    {
        Company Create(Company product);
        IEnumerable<Company> GetAll();
        void Delete(Guid id);
    }
}
