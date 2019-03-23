using Business;
using Model;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class ContatoController : ApiController
    {
        private ContatoBusiness _business;

        public ContatoController()
        {
            _business = new ContatoBusiness();
        }

        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _business.GetAll());
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        public HttpResponseMessage GetById([FromUri]int id)
        { 
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _business.GetById(id));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public HttpResponseMessage Update([FromBody]ContatoModel contato)
        {
            try
            {
                if (contato.Id == 0) throw new Exception("Usuário não existe");

                _business.Save(contato);

                return Request.CreateResponse(HttpStatusCode.OK, "Atualizado com sucesso");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPut]
        public HttpResponseMessage Add([FromBody]ContatoModel contato)
        {
            try
            {
                //pesquisar sobre tratamento de erros com ModelState.IsValid

                if(contato.Id != 0) throw new Exception("Id não permitido");

                _business.Save(contato);

                return Request.CreateResponse(HttpStatusCode.OK, "Adicionado com sucesso");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }

        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                if (id <= 0) throw new Exception("Id inválido");

                _business.Delete(id);

                return Request.CreateResponse(HttpStatusCode.OK, "Deletado com sucesso");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
