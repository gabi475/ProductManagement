using Common;
using Entities;
using Entities.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public IEnumerable<CompanyDetailDTO> GetAll()
        {
            return _context.Companies.Include(o => o.Products).Select(item => new CompanyDetailDTO
            {
                Id = item.Id,
                CEO = item.CEO,
                Location = item.Location,
                Revenue = item.Revenue,
                Year = item.Year,
                EmployeesNumber = item.EmployeesNumber,
                Name = item.Name,
                Products = item.Products.Select(o=>new ProductDetailDTO
                {
                    Id = o.Id,
                    Name = o.Name,
                    Price = o.Price
                }).ToList()
            });
        }
    }
}