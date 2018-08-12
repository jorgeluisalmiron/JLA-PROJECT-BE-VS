using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using JLA_Project.Models;
using JLA_Project.Repositories;

namespace JLA_Project.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly MyContextDB dbContext;
        
        public SupplierService(MyContextDB myContext)
        {
            dbContext = myContext;
        }

        public long Add(Supplier t)
        {
            Supplier c = dbContext.Suppliers.Add(t);
            dbContext.SaveChanges();
            return c.Id;
        }

        public bool Delete(long Id)
        {
            Supplier c = dbContext.Suppliers.Find(Id);
            if (!c.Equals(null))
            {
                dbContext.Suppliers.Remove(c);
                dbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<Supplier> GetAll()
        {
            return dbContext.Suppliers;

        }

        public Supplier GetById(long Id)
        {
            return dbContext.Suppliers.Find(Id);

        }

        public void Update(Supplier t)
        {
            dbContext.Suppliers.AddOrUpdate(t);
            dbContext.SaveChanges();
        }
    }
}