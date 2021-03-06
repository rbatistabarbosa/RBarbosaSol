using DojoDDD.Api.DojoDDD.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DojoDDD.Api.Controllers
{
    [ApiController]
    [Route("ordemcompra")]
    public class OrdemCompraController : Controller
    {
        private readonly IOrdemCompraServico _ordemCompraServico;

        public OrdemCompraController(IOrdemCompraServico ordemCompraServico)
        {
            _ordemCompraServico = ordemCompraServico;
        }

        [HttpGet]
        [Route("{idOrdemCompra}")]
        public async Task<IActionResult> ConsultarPorId([FromRoute] string idOrdemCompra)
        {
            try
            {
                var result = await _ordemCompraServico.ConsultarPorId(idOrdemCompra);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.ToString() });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] OrdemCompra ordemCompra)
        {
            try
            {
                var result = await _ordemCompraServico.RegistrarOrdemCompra(ordemCompra.ClienteId, ordemCompra.ProdutoId, ordemCompra.QuantidadeSolicitada);
                return Created(string.Empty, result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.ToString() });
            }
        }
    }
}
