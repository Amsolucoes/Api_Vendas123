using Domain.Dtos.Comprar;
using System;

namespace Domain.Models
{
    public class CompraModel : BaseModel
    {
        private Guid _id;
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int _numero;

        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public DateTime _dataVenda;

        public DateTime DataVenda
        {
            get { return _dataVenda; }
            set { _dataVenda = value; }
        }

        public Guid _cliente;

        public Guid Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        public decimal _valorTotalVendas;

        public decimal ValorTotalVendas
        {
            get { return _valorTotalVendas; }
            set { _valorTotalVendas = value; }
        }

        public int _filial;

        public int Filial
        {
            get { return _filial; }
            set { _filial = value; }
        }
    }
}
