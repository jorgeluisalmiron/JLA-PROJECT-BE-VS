using JLA_Project.Models;
using JLA_Project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace JLA_Project.Controllers
{
    public class SupplierController : ApiController
    {
        private ISupplierService supplierService;

    
        public SupplierController(ISupplierService supplierService)
        {
            this.supplierService = supplierService;
        }

        public HttpResponseMessage Get()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, supplierService.GetAll());
            }
            catch (Exception e)
            {
                Console.Write(e);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e);

            }
         }

        public HttpResponseMessage Get(long id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, supplierService.GetById(id));
            }
            catch (Exception e) {
                Console.Write(e);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e);
            }
        }

      
        public HttpResponseMessage Post(Supplier Supplier)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, supplierService.Add(Supplier));
            } 
            catch (Exception e)
            {
                Console.Write(e);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e);

            }
        }

        
        public HttpResponseMessage Put(Supplier Supplier)
        {
            try
            {
                supplierService.Update(Supplier);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                Console.Write(e);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e);

            }
        }

        public HttpResponseMessage Delete(long id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, supplierService.Delete(id));
            }
            catch (Exception e)
            {
                Console.Write(e);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e);
              
            }
        }
    }
}
