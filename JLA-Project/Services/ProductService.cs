using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using EntityFrameworkPaginate;
using JLA_Project.Models;
using JLA_Project.Repositories;
using JLA_Project.Utils;

namespace JLA_Project.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository productRepository;
        
        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public long Add(Product t)
        {
           return productRepository.Add(t);
        }

        public bool Delete(long id)
        {
            return productRepository.Delete(id);
        }

        public IEnumerable<Product> FindAll()
        {
            return productRepository.FindAll();

        }

        public Product FindById(long id)
        {
            return productRepository.FindById(id);

        }

        public Page<Product> FindAllByPage(PageDetails pageDetails)
        {
            return productRepository.FindByPage(pageDetails);
        }
      
        public Page<Product> SearchByPage(PageSearchDetails pageDetails)
        {
            return productRepository.FindByPage(pageDetails);
        }

        public void Update(Product t)
        {
            productRepository.Update(t);
        }
    }
}