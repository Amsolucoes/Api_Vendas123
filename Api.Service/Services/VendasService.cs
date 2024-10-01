using AutoMapper;
using Domain.Dtos.Comprar;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services.Vendas;
using Domain.Models;
using Serilog;
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
        private readonly ILogger _logger;

        public VendasService(IRepository<ComprarEntity> repository, IMapper mapper, ILogger logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<bool> Delete(Guid id)
        {
            _logger.Information("Apagando compra.");

            return await _repository.DeleteAsync(id);
        }

        public async Task<CompraDto> Post(CompraDto compra)
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

        public async Task<CompraDto> Put(CompraDto compra)
        {
            _logger.Information("Iniciando alteração de compra.");

            var vendaEncontrada = await _repository.SelectAsync(compra.Id);

            if (vendaEncontrada != null)
            {
                var model = _mapper.Map<CompraModel>(compra);
                var entity = _mapper.Map<ComprarEntity>(model);
                var result = await _repository.UpdateAsync(entity);

                _logger.Information("Finalizando alteração de compra.");

                return _mapper.Map<CompraDto>(result);
            }

            return null;
        }

        public async Task<CompraDto> GetCompra(Guid id)
        {
            _logger.Information("Iniciando procura de compra.");

            var result = await _repository.SelectAsync(id);

            _logger.Information("Finalizando procura de compra.");

            return _mapper.Map<CompraDto>(result);
        }
    }
}
