using Contas.Domain.Models;

namespace Contas.Service.Helpers
{
    public static class CalcHelper
    {
        public static ContaPagar MultaJuros(ContaPagar conta)
        {
            int diasAtrasado = conta.DiasAtrasado;

            if (diasAtrasado > 0)
            {
                decimal multa;
                decimal juros;

                if (diasAtrasado <= 3)
                {
                    multa = 2M;
                    juros = 0.1M;
                }
                else if (diasAtrasado > 3 && diasAtrasado <= 5)
                {
                    multa = 3M;
                    juros = 0.2M;
                }
                else
                {
                    multa = 5M;
                    juros = 0.3M;
                }

                conta.Multa = multa;
                conta.MultaValor = (conta.Valor * (multa / 100));
                conta.Juros = juros;
                conta.JurosValor = (conta.Valor * ((juros / 100) * diasAtrasado));
            }

            return conta;
        }
    }
}
