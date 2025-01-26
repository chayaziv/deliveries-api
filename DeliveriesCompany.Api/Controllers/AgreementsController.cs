﻿
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
    public class AgreementsController : ControllerBase
    {
        readonly IAgreementService _agreementService;
        readonly IMapper _mapper;

        public AgreementsController(IAgreementService agreementService,IMapper mapper)
        {
            _agreementService = agreementService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<AgreementDTO>> Get()
        {
            return _agreementService.getall();
        }

        [HttpGet("{id}")]
        public ActionResult<AgreementDTO> Get(int id)
        {
            if (_agreementService.getById(id) == null)
                return NotFound();
            return Ok(_agreementService.getById(id));
        }

        [HttpPost]
        public ActionResult<AgreementDTO> Post([FromBody] AgreementPostModel agreement)
        {
            var dto=_mapper.Map<AgreementDTO>(agreement);
           var agreementAdd = _agreementService.add(dto);
            if (agreementAdd != null)
                return Ok(agreementAdd);
            return BadRequest(agreementAdd);
        }


        [HttpPut("{id}")]
        public ActionResult<AgreementDTO> Put(int id, [FromBody] AgreementPostModel agreement)
        {
            var dto=_mapper.Map<AgreementDTO>(agreement);
            var agreementUpdate = _agreementService.update(id, dto);
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
