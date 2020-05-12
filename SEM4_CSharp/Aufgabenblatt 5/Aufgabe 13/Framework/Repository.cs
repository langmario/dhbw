using System.Collections.Generic;

namespace Aufgabe_13.Framework
{
    public class Repository<T> where T : class
    {
        public Repository(string databasefile)
        {
            NHibernateHelper.DatabaseFile = databasefile;
        }

        public IEnumerable<T> GetAll() {
            using (var session = NHibernateHelper.OpenSession())
            {
                var list = session.QueryOver<T>().List<T>();
                return list;
            }
        }

        public void Delete(T entity)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(entity);
                    transaction.Commit();
                }
            }
        }

        public void Save(T entity)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(entity);
                    transaction.Commit();
                }
            }
        }
    }
}
