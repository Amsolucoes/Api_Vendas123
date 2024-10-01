namespace Domain.Dtos.Comprar
{
    public class ProdutoDto
    {
        public string Nome { get; set; }

        public int Quantidade { get; set; }

        public decimal ValorUnitario { get; set; }

        public decimal Preco { get; set; }

        public decimal Desconto { get; set; }

        public decimal ValorTotal { get; set; }

        public bool Cancelado { get; set; }
    }
}
