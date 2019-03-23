using System;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class ContatoModel
    {
        public ContatoModel()
        {
            Sexo = new SexoModel();
        }

        public Int32 Id { get; set; }

        [Required]
        [Display(Name ="Nome Completo:")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Telefone Celular:")]
        public string Telefone { get; set; }

        [Required]
        [Display(Name = "Email:")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage ="Data obrigatória")]
        [Display(Name = "Data de Nascimento:")]
        public DateTime DataNascimento { get; set; }

        
        [Display(Name = "Sexo:")]
        public SexoModel Sexo { get; set; }
    }
}
