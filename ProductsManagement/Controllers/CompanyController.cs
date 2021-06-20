using Business;
using Common;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ProductsManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private ICompanyService _companyService;


        // quick constructor - tastezi 'ctor' si apesi TAB de 2 ori
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public IEnumerable<Company> GetAll()
        {
            return _companyService.GetAll();

        }

        [HttpPost]
        public IActionResult Create([FromBody] Company company)
        {
            var result = _companyService.Create(company);
            return Ok(result);
        }
    }
}
