
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
    public class DeliveryMenController : ControllerBase
    {
        readonly IDeliveryManService _deliveryManService;

        readonly IMapper _mapper;

        public DeliveryMenController(IDeliveryManService deliveryManService,IMapper mapper)
        {
            _deliveryManService = deliveryManService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult< List<DeliveryManDTO>> Get()
        {
            return _deliveryManService.getall();
        }

        [HttpGet("{id}")]
        public ActionResult<DeliveryManDTO> Get(int id)
        {
            if (_deliveryManService.getById(id) == null)
                return NotFound();
            return Ok(_deliveryManService.getById(id));

        }
        [HttpPost]
        public async Task<ActionResult<DeliveryManDTO>> Post([FromBody] DeliveryManPostModel deliveryMan)
        {
            var dto=_mapper.Map<DeliveryManDTO>(deliveryMan);
            var deliveryManAdd =await _deliveryManService.addAsync(dto);
           if (deliveryManAdd!=null )
                return Ok(deliveryManAdd);
           return BadRequest(deliveryManAdd);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<DeliveryManDTO>> Put(int id, [FromBody] DeliveryManPostModel deliveryMan)
        {
            var dto = _mapper.Map<DeliveryManDTO>(deliveryMan);
            var deliveryManUpdate =await _deliveryManService.updateAsync(id, dto);
            if (deliveryManUpdate!=null)
                return Ok(deliveryManUpdate);
            return BadRequest(deliveryManUpdate);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            if (!await _deliveryManService.deleteAsync(id))
                return BadRequest();
            return Ok();
        }
    }
}
