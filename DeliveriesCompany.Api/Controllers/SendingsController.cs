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
    public class SendingsController : ControllerBase
    {

        readonly ISendingService _sendingService;

        readonly IMapper _mapper;

        public SendingsController(ISendingService sendingService,IMapper mapper)
        {
            _sendingService = sendingService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<SendingDTO>> Get()
        {
            return _sendingService.getAll();
        }

        [HttpGet("{id}")]
        public ActionResult<SendingDTO> Get(int id)
        {
            if (_sendingService.getById(id) == null)
                return NotFound();
            return Ok(_sendingService.getById(id));
        }

        [HttpPost]
        public ActionResult<SendingDTO> Post([FromBody] SendingPostModel sending)
        {
            var dto = _mapper.Map<SendingDTO>(sending);
            var sendingAdd = _sendingService.add(dto);
            if (sendingAdd != null)
                return Ok(sendingAdd);
            return BadRequest(sendingAdd);
        }

        [HttpPut("{id}")]
        public ActionResult<SendingDTO> Put(int id, [FromBody] SendingPostModel sending)
        {
            var dto= _mapper.Map<SendingDTO>(sending);
            var sendingUpdate = _sendingService.update(id, dto);
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
