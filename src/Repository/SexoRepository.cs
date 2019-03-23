using DataAccess;
using Model;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class SexoRepository
    {
        public List<SexoModel> GetAll()
        {
            using(var db = new INCUBADORAEntities())
            {
               return db.TB_SEXO.ToList().ConvertAll
                (
                    //Data-Mapper
                    registro => new SexoModel
                    {
                        Id = registro.ID,
                        Sexo = registro.DS_SEXO
                    }
                );
            }
        }
    }
}
