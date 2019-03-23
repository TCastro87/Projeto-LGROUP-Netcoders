using Model;
using Repository;
using System.Collections.Generic;

namespace Business
{
    public class SexoBusiness
    {
        public List<SexoModel> GetAll()
        {
            return new SexoRepository().GetAll();
        }
    }
}
