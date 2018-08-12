using EntityFrameworkPaginate;
using JLA_Project.Models;
using JLA_Project.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JLA_Project.Services
{
    public interface IProductService
    {
        long Add(Product t);
        bool Delete(long id);
        void Update(Product t);
        IEnumerable<Product> FindAll();
        Product FindById(long id);
        Page<Product> FindAllByPage(PageDetails pageDetails);
        Page<Product> SearchByPage(PageSearchDetails pageDetails);
    }
}
