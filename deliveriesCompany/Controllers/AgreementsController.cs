﻿using deliveriesCompany.Entities;
using deliveriesCompany.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace deliveriesCompany.Controllers
{
    [Route("DeliveryCompany/[controller]")]
    [ApiController]
    public class AgreementsController : ControllerBase
    {
        readonly AgreementService _agreementService=new AgreementService();

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
            return Ok( _agreementService.getById(id));
        }

        [HttpPost]
        public ActionResult<bool> Post([FromBody] Agreement agreement)
        {
            if(_agreementService.add(agreement))
                return Ok();
            return BadRequest();
        }

    
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Agreement agreement)
        {
           if(! _agreementService.update(id, agreement))
                return NotFound();
           return Ok();
        }


        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
           if(! _agreementService.delete(id))
                return NotFound();
            return Ok();
        }
    }
}
