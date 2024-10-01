using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Domain.Interfaces.Services.Produtos;

namespace application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        public IProdutoService _service { get; set; }

        public ProdutosController(IProdutoService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("listar")]
        public async Task<IActionResult> ListarProdutos()
        {
            try
            {
                var produtos = await _service.ListarProdutos();
                return Ok(produtos);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> ObterProdutoPorId(Guid id)
        {
            try
            {
                var produto = await _service.ObterProdutoPorId(id);
                if (produto == null)
                    return NotFound();

                return Ok(produto);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
