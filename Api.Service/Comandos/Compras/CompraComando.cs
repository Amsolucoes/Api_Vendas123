using Domain.Dtos.Comprar;
using MediatR;
using Service.Dto.Resposta;

namespace Service.Comandos.Compras
{
    public class CompraComando : IRequest<Resposta>
    {
        public CompraDto Compra { get; set; }

        protected CompraComando(CompraDto compra) 
        {
            Compra = compra;
        }
    }
}
