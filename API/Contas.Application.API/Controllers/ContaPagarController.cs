using AutoMapper;
using Contas.Domain.Interfaces.Services;
using Contas.Domain.Models;
using Contas.Domain.RequestModels;
using Contas.Domain.ResponseModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Contas.Application.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaPagarController : ControllerBase
    {
        private readonly IContaPagarService service;
        private readonly IMapper mapper;

        public ContaPagarController(IContaPagarService service, IMapper mapper)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpPost]
        public IActionResult Insert([FromBody] ContaPagarRequest conta)
        {
            try
            {
                ContaPagar contaPagar = mapper.Map<ContaPagar>(conta);

                service.InsertWithCalc(contaPagar);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            try
            {
                service.Delete(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Select([FromRoute] int id)
        {
            try
            {
                ContaPagar conta = service.Find(id);

                ContaPagarResponse contaPagar = mapper.Map<ContaPagarResponse>(conta);

                return Ok(contaPagar);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]

        public IActionResult Select()
        {
            try
            {
                IEnumerable<ContaPagarResponse> contas = service
                                                            .List()
                                                            .Select(item => mapper.Map<ContaPagarResponse>(item));

                return Ok(contas);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
