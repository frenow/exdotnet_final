using Microsoft.AspNetCore.Mvc;
using ProjetoDotNet2.Modelo;
using ProjetoDotNet2.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDotNet2.Controllers
{
    public class ApiController : Controller
    {
        private IClienteRepositorio _clienteRepositorio;

        public ApiController(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }
        public IEnumerable<Cliente> GetListaClientes()
        {
            return _clienteRepositorio.getClientes();
        }
        public Cliente GetCliente(string id)
        {
            return _clienteRepositorio.GetCliente(id);
        }
    }
}
