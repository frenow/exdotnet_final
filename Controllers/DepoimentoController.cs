using Microsoft.AspNetCore.Mvc;
using ProjetoDotNet2.Modelo;
using ProjetoDotNet2.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDotNet2.Controllers
{
    public class DepoimentoController : Controller
    {
        public IActionResult Index([FromServices] IDepoimentoRepositorio depoimentoRepositorio)
        {
            List<Depoimento> depoimento = depoimentoRepositorio.getDepoimento();
            return View(depoimento);
        }
        [HttpGet]
        public IActionResult Editar(string id, [FromServices] IDepoimentoRepositorio depoimentoRepositorio)
        {
            Depoimento depoimento = depoimentoRepositorio.GetDepoimento(id);
            return View(depoimento);
        }

        [HttpPost]
        public IActionResult Editar(Depoimento depoimento, [FromServices] IDepoimentoRepositorio depoimentoRepositorio, [FromServices] IClienteRepositorio clienteRepositorio)
        {
            ViewBag.Clientes = repositorioClientes.GetClientes();
            
            depoimentoRepositorio.AtualizaDepoimento(depoimento);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Adicionar([FromServices] IClienteRepositorio repositorioCliente)
        {
            ViewBag.Clientes = repositorioCliente.GetClientes();
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(Depoimento depoimento, [FromServices] IDepoimentoRepositorio depoimentoRepositorio, [FromServices] IClienteRepositorio clienteRepositorio)
        {
            depoimento.Cliente = repositorioCliente.GetCliente(depoimento.CodigoCidade);
            depoimentoRepositorio.AdicionarDepoimento(depoimento);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Excluir(string id, [FromServices] IDepoimentoRepositorio depoimentoRepositorio)
        {
            depoimentoRepositorio.ExcluirDepoimento(id);

            return RedirectToAction("Index");
        }


    }
}
