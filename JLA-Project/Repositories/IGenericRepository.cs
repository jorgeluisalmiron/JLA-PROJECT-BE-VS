using EntityFrameworkPaginate;
using JLA_Project.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLA_Project.Repositories
{
    public interface IGenericRepository<T>
    {
        long Add(T t);
        void Update(T t);
        bool Delete(long Id);
        IEnumerable<T> FindAll();
        T FindById(long Id);
        Page<T> FindByPage(PageDetails pageDetails);
        Page<T> FindByPage(PageSearchDetails pageDetails);
    }
}
