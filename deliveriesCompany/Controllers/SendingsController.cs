using deliveriesCompany.Entities;
using deliveriesCompany.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace deliveriesCompany.Controllers
{
    [Route("DeliveryCompany/[controller]")]
    [ApiController]
    public class SendingsController : ControllerBase
    {

        readonly SendingService _sendingService = new SendingService();

        [HttpGet]
        public List<Sending> Get()
        {
            return _sendingService.getAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Sending> Get(int id)
        {
            if (_sendingService.get(id) == null)
                return NotFound();
            return Ok(_sendingService.get(id));
        }

        [HttpPost]
        public ActionResult<bool> Post([FromBody] Sending sending)
        {
            if(_sendingService.post(sending))
                return Ok();
            return BadRequest();
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Sending sending)
        {
            if (!_sendingService.put(id, sending))
                return NotFound();
            return Ok();
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
