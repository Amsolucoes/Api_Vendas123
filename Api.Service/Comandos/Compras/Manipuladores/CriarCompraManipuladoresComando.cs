using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Models;
using AutoMapper;
using Domain.Entities;
using Domain.Models;
using MediatR;
using Serilog;
using Service.Dto.Resposta;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Comandos.Compras.Manipuladores
{
    public class CriarCompraManipuladoresComando : IRequestHandler<CriarCompraComando, Resposta>
    {
        private readonly IRepository<ComprarEntity> _repository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public CriarCompraManipuladoresComando(IRepository<ComprarEntity> repository, IMapper mapper, ILogger logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Resposta> Handle(CriarCompraComando request, CancellationToken cancellationToken)
        {
            _logger.Information("Iniciando Processo de criar Compra");

            var comando = request.Compra;

            if (comando == null) 
            {
                var model = _mapper.Map<CompraModel>(comando);
                var entity = _mapper.Map<ComprarEntity>(model);
                var result = await _repository.InsertAsync(entity);

                return new Resposta();
            }

            return new Resposta();
        }
    }
}
