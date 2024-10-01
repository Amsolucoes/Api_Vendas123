using Api.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class ProdutoEntity : BaseEntity
    {
        public string Nome { get;  set; }
        
        public decimal Preco { get; set; }
        
        public int Quantidade { get; private set; }

        public decimal ValorUnitario { get; private set; }

        public decimal Desconto { get; private set; }

        public decimal ValorTotal { get; private set; }

        public bool Cancelado { get; private set; }

        public ComprarEntity Venda {  get; private set; }

        public ProdutoEntity() { }

        public ProdutoEntity(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public ICollection<ComprarEntity> Compras { get; set; }
    }
}
