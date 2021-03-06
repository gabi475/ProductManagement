using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public int Year { get; set; }

        public string Location { get; set; }

        public string CEO { get; set; }

        public int EmployeesNumber { get; set; }   

        public float Revenue { get; set; }
        public IList<Product> Products { get; set; }
    }
}
