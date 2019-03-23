using Model;
using Repository;
using System;
using System.Collections.Generic;

namespace Business
{
    public class ContatoBusiness
    {
        private ContatoRepository _repository;

        public ContatoBusiness()
        {
            _repository = new ContatoRepository();
        }

        public List<ContatoModel> GetAll()
        {
            return _repository.GetAll();
        }

        public void Save(ContatoModel contato)
        {
            //if (contato.Email == "email existente") throw new Exception("Usuário já existe");

            _repository.Save(contato);
        }

        public ContatoModel GetById(int id)
        {
            return _repository.GetById(id);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }
    }
}
