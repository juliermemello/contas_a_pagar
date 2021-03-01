using Contas.Domain.Models;
using System.Collections.Generic;

namespace Contas.Domain.Interfaces.Services
{
    public interface IService<T> where T : EntityModel
    {
        void Insert(T obj);

        void Update(T obj);

        void Delete(long id);

        T Find(long id);

        IList<T> List();
    }
}
