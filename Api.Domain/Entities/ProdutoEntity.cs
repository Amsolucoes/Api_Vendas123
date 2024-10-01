using Api.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class ProdutoEntity : BaseEntity
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public ProdutoEntity() { }

        public ProdutoEntity(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public ICollection<ComprarEntity> Compras { get; set; }
    }
}
