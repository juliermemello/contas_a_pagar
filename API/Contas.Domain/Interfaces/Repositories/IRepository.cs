using System;
using System.Collections.Generic;

namespace Contas.Domain.Interfaces.Repositories
{
    public interface IRepository<T> : IDisposable where T : IEntityModel
    {
        bool Insert(T obj);

        bool Update(T obj);

        bool Delete(long id);

        T Find(long id);

        IList<T> List();
    }
}
