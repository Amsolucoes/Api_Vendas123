using System;

namespace Domain.Dtos.Comprar
{
    public class CompraDto
    {
        public Guid Id { get; set; }

        public int Numero { get; set; }

        public DateTime DataVenda { get; set; }

        public Guid Cliente { get; set; }

        public decimal ValorTotalVendas { get; set; }

        public int Filial { get; set; }
    }
}
