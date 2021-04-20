using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic_Repository_Demo.Data
{
    public interface IGenericRepo<T>
    {
        Task<List<T>> GetAll();

        Task<T> Get(int id);

        Task<int> Create(T item);

        Task<int> Update(T item);

        Task<int> Delete(T item);

        Task<int> Delete(int id);
    }
}
