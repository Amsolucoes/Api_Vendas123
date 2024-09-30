namespace Service.Dto.Resposta
{
    public class Erro
    {
        public string NomePropriedade { get; set; }

        public string MensagemErro { get; set; }

        public Erro(string nomePropriedade, string mensagemErro)
        {
            NomePropriedade = nomePropriedade;
            MensagemErro = mensagemErro;
        }

        public Erro()
        {

        }
    }
}
