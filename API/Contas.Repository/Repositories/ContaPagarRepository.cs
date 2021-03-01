using Contas.Domain.Interfaces.Repositories;
using Contas.Domain.Models;
using Contas.Repository.Context;

namespace Contas.Repository.Repositories
{
    public class ContaPagarRepository : BaseRepository<ContaPagar>, IContaPagarRepository
    {
        public ContaPagarRepository(EntityContext context) : base(context)
        {

        }
    }
}
