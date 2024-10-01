using Api.Domain.Entities;
using System;

namespace Domain.Entities
{
    public class ProdutoEntity : BaseEntity
    {
        public string Nome { get; private set; }

        public int Quantidade { get; private set; }

        public decimal ValorUnitario { get; private set; }

        public decimal Desconto { get; private set; }

        public decimal ValorTotal { get; private set; }

        public bool Cancelado { get; private set; }

        public ComprarEntity Venda {  get; private set; }

        public ProdutoEntity() { }

        public void AlterarNome(string nome) => Nome = nome;

        public void AlterarQuantidadeProdutos(int quantidade) => Quantidade = quantidade;

        public void AlterarValorUnitário(decimal valorUnitario) => ValorUnitario = valorUnitario;

        public void AlterarDesconto(decimal desconto) => Desconto = desconto;

        public void AlterarValorTotal(decimal valorTotalProdutos) => ValorTotal = valorTotalProdutos;

        public void AlterarCancelado(bool cancelado) => Cancelado = cancelado;
    }
}
