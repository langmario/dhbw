using NHibernate;

namespace Aufgabe_14.Framework
{
    public interface INHibernateHelper
    {
        ISession OpenSession();
    }
}