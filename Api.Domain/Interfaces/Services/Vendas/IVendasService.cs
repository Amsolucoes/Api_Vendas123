using Domain.Dtos.Comprar;
using System;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Vendas
{
    public interface IVendasService
    {
        Task<CompraDto> Post(CompraDto user);

        Task<CompraDto> Put(CompraDto user);

        Task<bool> Delete(Guid id);

        Task<CompraDto> GetCompra(Guid id);
    }
}
