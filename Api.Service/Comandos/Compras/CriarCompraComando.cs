using Domain.Dtos.Comprar;

namespace Service.Comandos.Compras
{
    public class CriarCompraComando : CompraComando
    {
        public CriarCompraComando(CompraDto compra) : base(compra)
        {
        }
    }
}
