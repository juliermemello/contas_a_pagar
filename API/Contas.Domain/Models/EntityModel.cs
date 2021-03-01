using Contas.Domain.Interfaces;
using FluentValidation.Results;

namespace Contas.Domain.Models
{
    public abstract class EntityModel : IEntityModel
    {
        public int Id { get; set; }

        public abstract ValidationResult Validation();
    }
}
