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
    public class ClientController : ApiController
    {
        private IClientService clientService;


        public ClientController(IClientService clientService)
        {
            this.clientService = clientService;
        }

        public HttpResponseMessage Get()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, clientService.GetAll());
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
                return Request.CreateResponse(HttpStatusCode.OK, clientService.GetById(id));
            }
            catch (Exception e)
            {
                Console.Write(e);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e);
            }
        }


        public HttpResponseMessage Post(Client client)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, clientService.Add(client));
            }
            catch (Exception e)
            {
                Console.Write(e);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e);

            }
        }


        public HttpResponseMessage Put(Client client)
        {
            try
            {
                clientService.Update(client);
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
                return Request.CreateResponse(HttpStatusCode.OK, clientService.Delete(id));
            }
            catch (Exception e)
            {
                Console.Write(e);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e);

            }
        }
    }
}
