using Domain.Dtos.Comprar;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Produtos
{
    public interface IProdutoService
    {
        Task<IEnumerable<ProdutoEntity>> ListarProdutos();
        Task<ProdutoEntity> ObterProdutoPorId(Guid id);
        Task<ProdutoEntity> CriarProduto(ProdutoDto produtoDto);
    }
}
