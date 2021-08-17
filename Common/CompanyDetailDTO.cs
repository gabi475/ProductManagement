using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class CompanyDetailDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public int Year { get; set; }

        public string Location { get; set; }

        public string CEO { get; set; }

        public int EmployeesNumber { get; set; }

        public float Revenue { get; set; }
        public IList<ProductDetailDTO> Products { get; set; }
    }
}
