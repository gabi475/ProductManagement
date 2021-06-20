using Common;
using Entities;
using Entities.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Business
{
    public class CompanyService : ICompanyService
    {
        private ProductContext _context;

        public CompanyService(ProductContext context)
        {
            _context = context;
        }
        public Company Create(Company company)
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
            return company;
        }

        public void Delete(Guid id)
        {
            // stergere pe baza id-ului
        }

        public IEnumerable<Company> GetAll()
        {
            return _context.Companies.Include(o => o.Products);
        }
    }
}