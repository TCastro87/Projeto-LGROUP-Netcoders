using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class SexoModel
    {
        [Required(ErrorMessage = "Informe o sexo")]
        public int Id { get; set; }
        public string Sexo { get; set; }
    }
}
