using EntityFrameworkPaginate;
using JLA_Project.Models;
using JLA_Project.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace JLA_Project.Repositories
{
    public class ProductRepository:IProductRepository
    {
        private readonly MyContextDB dbContext;

        public ProductRepository(MyContextDB myContext)
        {
            dbContext = myContext;
        }

        public long Add(Product t)
        {
            Product p = dbContext.Products.Add(t);
            dbContext.SaveChanges();
            return p.Id;
        }

        public bool Delete(long Id)
        {
            Product p = dbContext.Products.Find(Id);
            if (!p.Equals(null))
            {
                dbContext.Products.Remove(p);
                dbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<Product> FindAll()
        {
            return dbContext.Products;

        }

        public Product FindById(long Id)
        {
            return dbContext.Products.Find(Id);

        }

        public Page<Product> FindByPage(PageDetails pageDetails)
        {
            Page<Product> products;
            Sorts<Product> sorts = SetSorts(pageDetails.SortByField, pageDetails.IsAscOrder);
            products = dbContext.Products.Paginate(pageDetails.PageNumber, pageDetails.PageSize, sorts);

            return products;
        }

        public Page<Product> FindByPage(PageSearchDetails pageDetails)
        {
            Page<Product> products;
            Sorts<Product> sorts = SetSorts(pageDetails.SortByField, pageDetails.IsAscOrder);

            var filters = new Filters<Product>();
            string field = pageDetails.Field;
            string searchText = pageDetails.SearchText;
            filters.Add(field.Equals("Code") && !string.IsNullOrEmpty(searchText), x => x.Code.Contains(searchText));
            filters.Add(field.Equals("Name") && !string.IsNullOrEmpty(searchText), x => x.Name.Contains(searchText));
            filters.Add(field.Equals("Mark") && !string.IsNullOrEmpty(searchText), x => x.Mark.Contains(searchText));
            filters.Add(field.Equals("Model") && !string.IsNullOrEmpty(searchText), x => x.Model.Contains(searchText));

            products = dbContext.Products.Paginate(pageDetails.PageNumber, pageDetails.PageSize, sorts, filters);

            return products;
        }

        private Sorts<Product> SetSorts(string sortByField, bool isAscOrder)
        {
            var sorts = new Sorts<Product>();
            sorts.Add(sortByField.Equals("Code"), x => x.Code, isAscOrder);
            sorts.Add(sortByField.Equals("Name"), x => x.Name, isAscOrder);
            sorts.Add(sortByField.Equals("Mark"), x => x.Mark, isAscOrder);
            sorts.Add(sortByField.Equals("Model"), x => x.Model, isAscOrder);
            return sorts;
        }

        public void Update(Product t)
        {
            dbContext.Products.AddOrUpdate(t);
            dbContext.SaveChanges();
        }

    }
}