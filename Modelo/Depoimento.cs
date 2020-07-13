using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDotNet2.Modelo
{
    public class Depoimento
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Cliente Cliente { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [StringLength(250, MinimumLength = 5)]
        [Display(Name = "Titulo do Depoimento")]
        [Required(ErrorMessage = "Informe o Titulo do Depoimento")]
        public string Titulo { get; set; }

        [StringLength(2000, MinimumLength = 10)]
        [Display(Name = "Depoimento")]
        [Required(ErrorMessage = "Informe o Depoimento")]
        public string Texto { get; set; }
    }
}
