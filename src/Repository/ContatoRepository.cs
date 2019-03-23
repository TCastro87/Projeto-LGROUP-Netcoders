using Model;
using System.Collections.Generic;
using DataAccess;
using System.Linq;
using Repository.Factories;

namespace Repository
{
    public class ContatoRepository
    {

        public List<ContatoModel> GetAll()
        {
            using (var db = new INCUBADORAEntities())
            {
                return db.TB_CONTATO.ToList().ConvertAll(ContatoFactory.ToModel);
            }
        }

        public void Save(ContatoModel contato)
        {
            using (var db = new INCUBADORAEntities())
            {
                if(contato.Id == 0)
                {
                    db.TB_CONTATO.Add(ContatoFactory.ToEntity(contato));
                }
                else
                {
                    var registro = db.TB_CONTATO.Single(x => x.ID == contato.Id);

                    ContatoFactory.ToEntity(contato, registro);
                }

                db.SaveChanges();
            }
        }

        public ContatoModel GetById(int id)
        {
            using (var db = new INCUBADORAEntities())
            {
                var registro = db.TB_CONTATO.Single(x => x.ID == id);

                return ContatoFactory.ToModel(registro);
            }
        }

        public bool Delete(int id)
        {
            using (var db = new INCUBADORAEntities())
            {
                var registro = db.TB_CONTATO.Single(x => x.ID == id);

                db.TB_CONTATO.Remove(registro);

                var qtde = db.SaveChanges();

                return qtde > 0;
            }
        }
    }
}
