using System;

namespace Contas.Domain.RequestModels
{
    public class ContaPagarRequest
    {
        public string Nome { get; set; }

        public decimal Valor { get; set; }

        public DateTime DataVencimento { get; set; }

        public DateTime DataPagamento { get; set; }
    }
}
