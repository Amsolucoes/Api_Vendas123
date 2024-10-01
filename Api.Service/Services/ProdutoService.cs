using Api.Domain.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services.Produtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IRepository<ProdutoEntity> _repository;

        public ProdutoService(IRepository<ProdutoEntity> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ProdutoEntity>> ListarProdutos()
        {
            return await _repository.SelectAsync();
        }

        public async Task<ProdutoEntity> ObterProdutoPorId(Guid id)
        {
            return await _repository.SelectAsync(id);
        }
    }
}
