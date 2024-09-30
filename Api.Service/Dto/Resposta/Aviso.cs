namespace Service.Dto.Resposta
{
    public class Aviso
    {
        public string NomePropriedade { get; set; }

        public string MensagemErro { get; set; }

        public Aviso(string nomePropriedade, string mensagemErro)
        {
            NomePropriedade = nomePropriedade;
            MensagemErro = mensagemErro;
        }

        public Aviso()
        {

        }
    }
}
