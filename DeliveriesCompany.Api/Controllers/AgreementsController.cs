
using DeliveriesCompany.Core.Entity;
using DeliveriesCompany.Core.Iservices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DeliveriesCompany.Api.Controllers
{
    [Route("DeliveryCompany/[controller]")]
    [ApiController]
    public class AgreementsController : ControllerBase
    {
        readonly IAgreementService _agreementService;

        public AgreementsController(IAgreementService agreementService)
        {
            _agreementService = agreementService;
        }

        [HttpGet]
        public ActionResult<List<Agreement>> Get()
        {
            return _agreementService.getall();
        }

        [HttpGet("{id}")]
        public ActionResult<Agreement> Get(int id)
        {
            if (_agreementService.getById(id) == null)
                return NotFound();
            return Ok(_agreementService.getById(id));
        }

        [HttpPost]
        public ActionResult<Agreement> Post([FromBody] Agreement agreement)
        {
            Agreement agreementAdd = _agreementService.add(agreement);
            if (agreementAdd != null)
                return Ok(agreementAdd);
            return BadRequest(agreementAdd);
        }


        [HttpPut("{id}")]
        public ActionResult<Agreement> Put(int id, [FromBody] Agreement agreement)
        {
            Agreement agreementUpdate = _agreementService.update(id, agreement);
            if (agreementUpdate != null)
                return Ok(agreementUpdate);
            return NotFound(agreementUpdate);

        }


        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (!_agreementService.delete(id))
                return NotFound();
            return Ok();
        }
    }
}
