using Api.Domain.Entities;
using System;

namespace Domain.Entities
{
    public class ComprarEntity : BaseEntity
    {
        public int Numero { get; private set; }

        public DateTime DataVenda { get; private set; }

        public Guid Cliente { get; private set; }

        public decimal ValorTotalVendas { get; private set; }

        public int Filial { get; private set; }

        public ComprarEntity() { }

        public void AlterarNumeroCompra(int numeroCompra) => Numero = numeroCompra;

        public void AlterarDataVenda(DateTime dataVenda) => DataVenda = dataVenda;

        public void AlterarCliente(Guid cliente) => Cliente = cliente;

        public void AlterarValorTotalVendas(decimal valorTotalVendas) => ValorTotalVendas = valorTotalVendas;

        public void AlterarFilial(int filial) => Filial = filial;


    }
}
