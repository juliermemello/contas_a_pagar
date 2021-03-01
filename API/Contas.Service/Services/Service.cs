using Contas.Domain.Interfaces.Repositories;
using Contas.Domain.Interfaces.Services;
using Contas.Domain.Models;
using System;
using System.Collections.Generic;

namespace Contas.Service.Services
{
    public class Service<T> : IService<T> where T : EntityModel
    {
        private readonly IRepository<T> repository;

        public Service(IRepository<T> repository) => this.repository = repository;

        public void Insert(T obj)
        {
            bool result = repository.Insert(obj);

            if (!result)
                throw new Exception("Erro ao tentar inserir um novo registro.");
        }

        public void Update(T obj)
        {
            bool result = repository.Update(obj);

            if (!result)
                throw new Exception("Erro ao tentar editar o registro selecionado.");
        }

        public void Delete(long id)
        {
            bool result = repository.Delete(id);

            if (!result)
                throw new Exception("Erro ao tentar apagar o registro selecionado.");
        }

        public T Find(long id) => repository.Find(id);

        public IList<T> List() => repository.List();
    }
}
