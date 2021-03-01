using Contas.Domain.Models;

namespace Contas.Domain.Interfaces.Services
{
    public interface IContaPagarService : IService<ContaPagar>
    {
        void InsertWithCalc(ContaPagar conta);
    }
}
