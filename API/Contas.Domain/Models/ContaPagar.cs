using Contas.Domain.Validators.Models;
using FluentValidation.Results;
using System;

namespace Contas.Domain.Models
{
    public class ContaPagar : EntityModel
    {
        public string Nome { get; set; }

        public decimal Valor { get; set; }

        public DateTime DataVencimento { get; set; }

        public DateTime DataPagamento { get; set; }

        public int DiasAtrasado { get; set; }

        public decimal Multa { get; set; }

        public decimal MultaValor { get; set; }

        public decimal Juros { get; set; }

        public decimal JurosValor { get; set; }

        public override ValidationResult Validation() 
            => new ContaPagarValidator().Validate(this);
    }
}
