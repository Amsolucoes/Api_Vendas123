using System;

namespace Domain.Dtos.Comprar
{
    public class CompraDto
    {
        public int Numero { get; set; }

        public DateTime DataVenda { get; set; }

        public Guid Cliente { get; set; }

        public decimal ValorTotalVendas { get; set; }

        public int Filial { get; set; }
    }
}
