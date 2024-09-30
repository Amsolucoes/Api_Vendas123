using Domain.Dtos.Comprar;
using Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Vendas
{
    public interface IVendasService
    {
        Task<ComprarEntity> Post(CompraDto user);
        Task<ComprarEntity> Put(CompraDto user);
        Task<bool> Delete(Guid id);
    }
}
