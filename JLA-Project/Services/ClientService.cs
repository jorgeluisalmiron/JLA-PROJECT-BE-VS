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
    public class ClientService : IClientService
    {
        private readonly MyContextDB dbContext;
        
        public ClientService (MyContextDB myContext)
        {
            dbContext = myContext;
        }

        public long Add(Client t)
        {
            Client c = dbContext.Clients.Add(t);
            dbContext.SaveChanges();
            return c.Id;
        }

        public bool Delete(long Id)
        {
            Client c = dbContext.Clients.Find(Id);
            if (!c.Equals(null))
            {
                dbContext.Clients.Remove(c);
                dbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<Client> GetAll()
        {
            return dbContext.Clients;

        }

        public Client GetById(long Id)
        {
            return dbContext.Clients.Find(Id);

        }

        public void Update(Client t)
        {
            dbContext.Clients.AddOrUpdate(t);
            dbContext.SaveChanges();
        }
    }
}