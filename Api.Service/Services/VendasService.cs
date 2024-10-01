using Api.Domain.Interfaces;
using AutoMapper;
using Domain.Dtos.Comprar;
using Domain.Entities;
using Domain.Interfaces.Services.Vendas;
using Domain.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Services
{
    public class VendasService : IVendasService
    {
        private IRepository<ComprarEntity> _repository;

        private IRepository<ProdutoEntity> _produtoRepository;
        private readonly IMapper _mapper;

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<ComprarEntity> Post(CompraDto compra)
        {
            var model = _mapper.Map<CompraModel>(compra);
            var entity = _mapper.Map<ComprarEntity>(model);

            if (compra.ProdutosIds != null && compra.ProdutosIds.Any())
            {
                foreach (var produtoId in compra.ProdutosIds)
                {
                    var produto = await _produtoRepository.SelectAsync(produtoId);
                    if (produto != null)
                    {
                        entity.AdicionarProduto(produto);
                    }
                }
            }

            var result = await _repository.InsertAsync(entity);
            return _mapper.Map<ComprarEntity>(result);
        }


        public async Task<ComprarEntity> Put(CompraDto compra)
        {
            var model = _mapper.Map<CompraModel>(compra);
            var entity = _mapper.Map<ComprarEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<ComprarEntity>(result);
        }
    }
}
