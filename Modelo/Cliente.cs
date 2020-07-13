using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDotNet2.Modelo
{
    public class Cliente
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(20)]
        [Display(Name = "Documento CPF")]
        [Required(ErrorMessage = "Informe o Documento")]
        public string Cpf { get; set; }

        [StringLength(250)]
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Informe o Nome")]
        public string Nome { get; set; }

        [Required]
        [StringLength(400)]
        [RegularExpression(@"^[-a-zA-Z0-9][-.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[-.a-zA-Z0-9]+)*\.(com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|tv|[a-zA-Z]{2})$", ErrorMessage = "Formato inválido de e-mail")]
        public string Email { get; set; }

    }
}
