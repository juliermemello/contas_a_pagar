using Contas.Domain.Models;

namespace Contas.Domain.ResponseModels
{
    public class ContaPagarResponse : ContaPagar
    {
        public decimal ValorCorrigido { get { return Valor + MultaValor + JurosValor; } }
    }
}
