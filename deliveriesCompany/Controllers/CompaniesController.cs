using deliveriesCompany.Entities;
using deliveriesCompany.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace deliveriesCompany.Controllers
{
    [Route("DeliveryCompany/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {

         readonly CompanyService _companyService = new CompanyService();

        [HttpGet]
        public List<Company> Get()
        {
           return _companyService.getAll();
        }
    
        [HttpGet("{id}")]
        public ActionResult< Company> Get(int id)
        {
           if( _companyService.getById(id)==null)
                return NotFound();
           return Ok(_companyService.getById(id));
        }

        
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Company company)
        {
            if(_companyService.add(company))
                return Ok();
            return BadRequest();
        }

        
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Company company)
        {
            if(! _companyService.update(id, company))
                return NotFound();
            return Ok();
        }

        
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
           if(! _companyService.delete(id))
                return NotFound();
           return Ok();
        }
    }
}
