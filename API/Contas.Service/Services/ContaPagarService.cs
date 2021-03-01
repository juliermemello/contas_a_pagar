using Contas.Domain.Interfaces.Repositories;
using Contas.Domain.Interfaces.Services;
using Contas.Domain.Models;
using Contas.Service.Helpers;
using System;

namespace Contas.Service.Services
{
    public class ContaPagarService : Service<ContaPagar>, IContaPagarService
    {
        private readonly IContaPagarRepository repository;

        public ContaPagarService(IContaPagarRepository repository) : base(repository) 
            => this.repository = repository;

        public void InsertWithCalc(ContaPagar conta)
        {
            try
            {
                int diasAtrasado = (conta.DataPagamento - conta.DataVencimento).Days;

                if (diasAtrasado > 0)
                {
                    conta.DiasAtrasado = diasAtrasado;

                    conta = CalcHelper.MultaJuros(conta);
                }

                Insert(conta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
