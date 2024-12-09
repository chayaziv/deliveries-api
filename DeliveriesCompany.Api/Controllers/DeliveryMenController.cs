﻿
using DeliveriesCompany.Core.Entity;

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

        public DeliveryMenController(IDeliveryManService deliveryManService)
        {
            _deliveryManService = deliveryManService;
        }

        [HttpGet]
        public ActionResult< List<DeliveryMan>> Get()
        {
            return _deliveryManService.getall();
        }

        [HttpGet("{id}")]
        public ActionResult<DeliveryMan> Get(int id)
        {
            if (_deliveryManService.getById(id) == null)
                return NotFound();
            return Ok(_deliveryManService.getById(id));

        }
        [HttpPost]
        public ActionResult Post([FromBody] DeliveryMan deliveryMan)
        {
           if( _deliveryManService.add(deliveryMan))
                return Ok();
           return BadRequest();
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] DeliveryMan deliveryMan)
        {
            if (!_deliveryManService.update(id, deliveryMan))
                return NotFound();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (!_deliveryManService.delete(id))
                return BadRequest();
            return Ok();
        }
    }
}