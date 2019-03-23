using DataAccess;
using Model;

namespace Repository.Factories
{
    public static class ContatoFactory
    {
        public static ContatoModel ToModel(TB_CONTATO tabela)
        {
            return new ContatoModel
            {
                Id = tabela.ID,
                DataNascimento = tabela.DS_NASCIMENTO,
                Email = tabela.DS_EMAIL,
                Nome = tabela.NM_CONTATO,
                Telefone = tabela.DS_TELEFONE,
                Sexo = new SexoModel
                {
                    Id = tabela.TB_SEXO.ID,
                    Sexo = tabela.TB_SEXO.DS_SEXO
                }
            };
        }

        public static TB_CONTATO ToEntity(ContatoModel model)
        {
            return new TB_CONTATO
            {
                ID = model.Id,
                DS_EMAIL = model.Email,
                DS_TELEFONE = model.Telefone,
                DS_NASCIMENTO = model.DataNascimento,
                NM_CONTATO = model.Nome,
                ID_SEXO = model.Sexo.Id,
            };
        }

        public static void ToEntity(ContatoModel model, TB_CONTATO registro)
        {
            registro.ID = model.Id;
            registro.DS_EMAIL = model.Email;
            registro.DS_TELEFONE = model.Telefone;
            registro.DS_NASCIMENTO = model.DataNascimento;
            registro.NM_CONTATO = model.Nome;
            registro.ID_SEXO = model.Sexo.Id;
        }
    }
}
