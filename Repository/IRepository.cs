using System.Collections.Generic;

namespace ACCFlexTask.Repository
{
    public interface IRepository<T>
    {
        T GetById(int id);
        List<T> GetAll();
        int Insert(T entity);
        int Update(int id, T entity);
        int Delete(int id);
    }
}
