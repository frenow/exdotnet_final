using Microsoft.AspNetCore.Mvc;
using ProjetoDotNet2.Modelo;
using ProjetoDotNet2.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDotNet2.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index([FromServices] IClienteRepositorio clienteRepositorio)
        {
            List<Cliente> clientes = clienteRepositorio.getClientes();
            return View(clientes);
        }
        [HttpGet]
        public IActionResult Editar(string id, [FromServices] IClienteRepositorio clienteRepositorio)
        {
            Cliente cliente = clienteRepositorio.GetCliente(id);
            return View(cliente);
        }

        [HttpPost]
        public IActionResult Editar(Cliente cliente, [FromServices] IClienteRepositorio clienteRepositorio)
        {
            clienteRepositorio.AtualizaCliente(cliente);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(Cliente cliente, [FromServices] IClienteRepositorio clienteRepositorio)
        {
            clienteRepositorio.AdicionarCliente(cliente);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Excluir(string id, [FromServices] IClienteRepositorio clienteRepositorio)
        {
            clienteRepositorio.ExcluirCliente(id);

            return RedirectToAction("Index");
        }
    }
}
