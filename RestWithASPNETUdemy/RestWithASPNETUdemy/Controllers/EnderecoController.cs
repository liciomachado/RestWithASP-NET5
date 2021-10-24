using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestCrudApi.Model;
using RestCrudApi.Business;
using RestCrudApi.HypermediaFilterOptions.Filters;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace RestCrudApi.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Authorize("Bearer")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IEnderecoBusiness _EnderecoBusiness;

        public EnderecoController(ILogger<ProductController> logger, IEnderecoBusiness EnderecoBusiness)
        {
            _logger = logger;
            _EnderecoBusiness = EnderecoBusiness;
        }

        [HttpGet]
        [TypeFilter(typeof(HyperMediaFilter))]
        [ProducesResponseType((200), Type = typeof(List<EnderecoVO>))]
        [ProducesResponseType((204))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]
        public IActionResult Get()
        {
            return Ok(_EnderecoBusiness.FindAll());
        }

        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        [ProducesResponseType((200), Type = typeof(EnderecoVO))]
        [ProducesResponseType((204))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]
        public IActionResult Get(long id)
        {
            var endereco = _EnderecoBusiness.FindById(id);
            if(endereco == null) return NotFound();
            return Ok(endereco);
        }

        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilter))]
        [ProducesResponseType((200), Type = typeof(EnderecoVO))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]
        public IActionResult Post([FromBody] EnderecoVO endereco)
        {
            if (endereco == null) return NotFound();
            return Ok(_EnderecoBusiness.Create(endereco));
        }

        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilter))]
        [ProducesResponseType((200), Type = typeof(EnderecoVO))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]
        public IActionResult Put([FromBody] EnderecoVO endereco)
        {
            if (endereco == null) return NotFound();
            return Ok(_EnderecoBusiness.Update(endereco));
        }

        [HttpDelete("{id}")]
        [ProducesResponseType((204))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]
        public IActionResult Delete(long id)
        {
            _EnderecoBusiness.Delete(id);
            return NoContent();
        }
    }
}
