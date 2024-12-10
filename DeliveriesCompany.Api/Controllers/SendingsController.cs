
using DeliveriesCompany.Core.Entity;
using DeliveriesCompany.Core.Iservices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DeliveriesCompany.Api.Controllers
{
    [Route("DeliveryCompany/[controller]")]
    [ApiController]
    public class SendingsController : ControllerBase
    {

        readonly ISendingService _sendingService;

        public SendingsController(ISendingService sendingService)
        {
            _sendingService = sendingService;
        }

        [HttpGet]
        public ActionResult<List<Sending>> Get()
        {
            return _sendingService.getAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Sending> Get(int id)
        {
            if (_sendingService.getById(id) == null)
                return NotFound();
            return Ok(_sendingService.getById(id));
        }

        [HttpPost]
        public ActionResult<Sending> Post([FromBody] Sending sending)
        {
            Sending sendingAdd = _sendingService.add(sending);
            if (sendingAdd != null)
                return Ok(sendingAdd);
            return BadRequest(sendingAdd);
        }

        [HttpPut("{id}")]
        public ActionResult<Sending> Put(int id, [FromBody] Sending sending)
        {
            Sending sendingUpdate = _sendingService.update(id, sending);
            if (sendingUpdate != null)
                return Ok(sendingUpdate);
            return NotFound(sendingUpdate);

        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (!_sendingService.delete(id))
                return NotFound();
            return Ok();
        }
    }
}
