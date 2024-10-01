using AutoMapper;
using Domain.Dtos.Comprar;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services.Vendas;
using Domain.Models;
using Serilog;
using System;
using System.Threading.Tasks;

namespace Service.Services
{
    public class VendasService : IVendasService
    {
        private IRepository<ComprarEntity> _repository;
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
            _logger.Information("Iniciando criação de compra.");

            if (compra != null)
            {
                var model = _mapper.Map<CompraModel>(compra);
                var entity = _mapper.Map<ComprarEntity>(model);
                var result = await _repository.UpdateAsync(entity);

                await _repository.InsertAsync(result);

                _logger.Information("Finalizando Criação de compra.");

                return _mapper.Map<CompraDto>(result);
            }

            _logger.Information("Não foi possível criar compra.");

            return null;
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
