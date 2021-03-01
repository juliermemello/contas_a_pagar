using Contas.Domain.RequestModels;
using FluentValidation;

namespace Contas.Domain.Validators.RequestModels
{
    public class ContaPagarRequestValidator : AbstractValidator<ContaPagarRequest>
    {
        public ContaPagarRequestValidator()
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
