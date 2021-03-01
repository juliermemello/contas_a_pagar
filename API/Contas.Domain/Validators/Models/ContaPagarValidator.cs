using Contas.Domain.Models;
using FluentValidation;

namespace Contas.Domain.Validators.Models
{
    public class ContaPagarValidator : AbstractValidator<ContaPagar>
    {
        public ContaPagarValidator()
        {
            CascadeMode = CascadeMode.Continue;

            RuleFor(x => x.Nome)
                .NotNull().WithMessage("O campo {PropertyName} não pode ser nulo.")
                .NotEmpty().WithMessage("O campo {PropertyName} não pode estar vazio.");

            RuleFor(x => x.Valor)
                .GreaterThan(0).WithMessage("O campo {PropertyName} deve ser maior que 0.");

            RuleFor(x => x.DataVencimento)
                .NotNull().WithMessage("O campo {PropertyName} não pode ser nulo.")
                .NotEmpty().WithMessage("O campo {PropertyName} não pode estar vazio.");

            RuleFor(x => x.DataPagamento)
                .NotNull().WithMessage("O campo {PropertyName} não pode ser nulo.")
                .NotEmpty().WithMessage("O campo {PropertyName} não pode estar vazio.");
        }
    }
}
