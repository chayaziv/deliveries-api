
using DeliveriesCompany.Core.Entity;
using DeliveriesCompany.Core.Iservices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DeliveriesCompany.Api.Controllers
{
    [Route("DeliveryCompany/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {

        readonly ICompanyService _companyService;

        public CompaniesController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public ActionResult<List<Company>> Get()
        {
            return _companyService.getAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Company> Get(int id)
        {
            if (_companyService.getById(id) == null)
                return NotFound();
            return Ok(_companyService.getById(id));
        }


        [HttpPost]
        public ActionResult<Company> Post([FromBody] Company company)
        {
            Company companyAdd = _companyService.add(company);
            if (companyAdd!=null)
                return Ok(companyAdd);
            return BadRequest(companyAdd);
        }


        [HttpPut("{id}")]
        public ActionResult<Company> Put(int id, [FromBody] Company company)
        {
            Company companyUpdate = _companyService.update(id, company);
            if (companyUpdate!= null)
                return Ok(companyUpdate);
            return BadRequest(companyUpdate);
        }


        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (!_companyService.delete(id))
                return NotFound();
            return Ok();
        }
    }
}
