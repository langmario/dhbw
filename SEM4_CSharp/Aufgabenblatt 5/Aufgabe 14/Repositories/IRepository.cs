using System.Collections.Generic;

namespace Aufgabe_14.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        void Save(T entity);
        void Delete(T entity);
    }
}
