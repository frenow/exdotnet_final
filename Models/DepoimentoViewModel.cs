using AulaFullStack.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDotNet2.Models
{
    public class DepoimentoViewModel : Assinatura
    {
        [Required]
        [Display(Name = "Depoimento")]
        public string CodigoDepoimento { get; set; }

        internal void SetDepoimentoViewModel(Depoimento depoimento)
        {
            this.Id = depoimento.Id;
            this.Data = depoimento.Data;
            this.Titulo = depoimento.Titulo;
            this.Texto = depoimento.Texto;
            this.CodigoCliente = depoimento.Cliente.Id.ToString();
        }
    }
}
