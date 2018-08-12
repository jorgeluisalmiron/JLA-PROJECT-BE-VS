using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JLA_Project.Services
{
    public interface IGenericService<T>
    {
        long Add(T t);
        void Update(T t);
        bool Delete(long Id);
        IEnumerable<T> GetAll();
        T GetById(long Id);

    }
}
