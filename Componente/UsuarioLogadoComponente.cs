using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDotNet2.Componentes
{
    public class UsuarioLogadoComponente : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            if (User.Identity.IsAuthenticated)
                return View((object)User.Identity.Name);
            else
                return View((object)"Não logado");
        }
    }
}
