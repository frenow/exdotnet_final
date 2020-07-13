using ProjetoDotNet2.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDotNet2.Models
{
    public class ClienteIndexViewModel
    {
        public List<Cliente> Clientes { get; set; }

        public int QtdRegistro { get; set; }

        public int QtdRegistroMG { get; set; }
    }
}
