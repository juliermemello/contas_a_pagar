using Contas.Domain.Interfaces.Repositories;
using Contas.Domain.Models;
using Contas.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Contas.Repository.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : EntityModel
    {
        protected readonly EntityContext Db;
        protected readonly DbSet<T> DbSet;

        public BaseRepository(EntityContext context)
        {
            Db = context;
            DbSet = Db.Set<T>();
        }

        public bool Insert(T obj)
        {
            try
            {
                DbSet.Add(obj);

                int result = Db.SaveChanges();

                return (result == 1);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(T obj)
        {
            try
            {
                if (Db.Set<T>().AsNoTracking().FirstOrDefault(x => x.Id == obj.Id) != null)
                {
                    DbSet.Update(obj);

                    int result = Db.SaveChanges();

                    return (result == 1);
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(long id)
        {
            try
            {
                T obj = Find(id);

                if (obj != null)
                    if (Db.Set<T>().AsNoTracking().FirstOrDefault(x => x.Id == obj.Id) != null)
                    {
                        DbSet.Remove(Find(id));

                        int result = Db.SaveChanges();

                        return (result == 1);
                    }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public T Find(long id) => Db.Set<T>().FirstOrDefault(x => x.Id == id);

        public IList<T> List() => Db.Set<T>().ToList();

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
