
using AutoMapper;
using DeliveriesCompany.Api.PostModels;
using DeliveriesCompany.Core.Entity;
using DeliveriesCompany.Core.EntityDTO;
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

        readonly IMapper _mapper;

        public CompaniesController(ICompanyService companyService,IMapper mapper)
        {
            _companyService = companyService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<CompanyDTO>> Get()
        {
            return _companyService.getAll();
        }

        [HttpGet("{id}")]
        public ActionResult<CompanyDTO> Get(int id)
        {
            if (_companyService.getById(id) == null)
                return NotFound();
            return Ok(_companyService.getById(id));
        }


        [HttpPost]
        public ActionResult<CompanyDTO> Post([FromBody] CompanyPostModel company)
        {
            var dto=_mapper.Map<CompanyDTO>(company);
            var companyAdd = _companyService.add(dto);
            if (companyAdd!=null)
                return Ok(companyAdd);
            return BadRequest(companyAdd);
        }


        [HttpPut("{id}")]
        public ActionResult<CompanyDTO> Put(int id, [FromBody] CompanyPostModel company)
        {
            var dto = _mapper.Map<CompanyDTO>(company);
            var companyUpdate = _companyService.update(id, dto);
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
