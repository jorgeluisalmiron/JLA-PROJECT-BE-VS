using JLA_Project.Models;
using JLA_Project.Services;
using JLA_Project.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace JLA_Project.Controllers
{
    public class ProductController : ApiController
    {
        private IProductService productService;

    
        public ProductController(IProductService ProductService)
        {
            this.productService = ProductService;
        }

        public HttpResponseMessage Get()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, productService.FindAll());
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
                return Request.CreateResponse(HttpStatusCode.OK, productService.FindById(id));
            }
            catch (Exception e) {
                Console.Write(e);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e);
            }
        }

      
        public HttpResponseMessage Post(Product Product)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, productService.Add(Product));
            } 
            catch (Exception e)
            {
                Console.Write(e);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e);

            }
        }

        
        public HttpResponseMessage Put(Product Product)
        {
            try
            {
                productService.Update(Product);
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
                return Request.CreateResponse(HttpStatusCode.OK, productService.Delete(id));
            }
            catch (Exception e)
            {
                Console.Write(e);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e);

            }
        }

        [Route("FindAllByPagination")]
        [HttpPost]
        public HttpResponseMessage FindAllByPagination(PageDetails pageDetails)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, productService.FindAllByPage(pageDetails));
            }
            catch (Exception e)
            {
                Console.Write(e);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e);

            }
        }
        [Route("SearchByPagination")]
        [HttpPost]
        public HttpResponseMessage SearchByPagination(PageSearchDetails pageDetails)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, productService.SearchByPage(pageDetails));
            }
            catch (Exception e)
            {
                Console.Write(e);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e);

            }
        }
    }
}
