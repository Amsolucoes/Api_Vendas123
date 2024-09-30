using System.Collections.Generic;
using System.Linq;

namespace Service.Dto.Resposta
{
    public class Resposta
    {
        public List<Erro> Erros { get; protected set; } = new List<Erro>();
        public List<Aviso> Avisos { get; protected set; } = new List<Aviso>();

        public object? Resultado { get; set; }

        private string _localizacaoObjetoCriado = string.Empty;

        public Resposta(object resultado)
        {
            Resultado = resultado;
        }

        public Resposta()
        {

        }

        public void AdicionarErro(Erro erro) => Erros.Add(erro);

        public void AdicionarErro(string nomePropriedade, string mensagemErro) => Erros.Add(new Erro(nomePropriedade, mensagemErro));

        public void AdicionarAviso(string nomePropriedade, string mensagemErro) => Avisos.Add(new Aviso(nomePropriedade, mensagemErro));

        public bool IsValid() => !Erros.Any();

        public void LimparErros() => Erros.Clear();

        public string ObterLocalizacao() => _localizacaoObjetoCriado;

        public void DefinirLocalizacao(string localizacao) => _localizacaoObjetoCriado = localizacao;
    }
}
