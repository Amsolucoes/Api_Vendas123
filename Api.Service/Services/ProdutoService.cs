using AutoMapper;
using Domain.Dtos.Comprar;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services.Produtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IRepository<ProdutoEntity> _repository;
        private readonly IMapper _mapper;

        public ProdutoService(IRepository<ProdutoEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProdutoEntity>> ListarProdutos()
        {
            return await _repository.SelectAsync();
        }

        public async Task<ProdutoEntity> ObterProdutoPorId(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<ProdutoEntity> CriarProduto(ProdutoDto produtoDto)
        {
            var produtoEntity = _mapper.Map<ProdutoEntity>(produtoDto);
            var result = await _repository.InsertAsync(produtoEntity);
            return result;
        }
    }
}
