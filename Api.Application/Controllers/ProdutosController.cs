using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Domain.Interfaces.Services.Produtos;
using Domain.Dtos.Comprar;
using Microsoft.AspNetCore.Authorization;

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

        [Authorize("Bearer")]
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

        [Authorize("Bearer")]
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

        [Authorize("Bearer")]
        [HttpPost]
        [Route("criar")]
        public async Task<IActionResult> CriarProduto([FromBody] ProdutoDto produtoDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  // 400 Bad Request - Solicitação Inválida
            }
            try
            {
                var result = await _service.CriarProduto(produtoDto);
                return Created(new Uri(Url.Link("GetWithId", new { id = result.Id })), result);
            }
            catch (ArgumentException e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
