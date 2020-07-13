using ProjetoDotNet2.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDotNet2.Repositorio
{
    public interface IClienteRepositorio
    {
        List<Cliente> getClientes();
        void AdicionarCliente(Cliente cliente);
        Cliente GetCliente(string id);
        void AtualizaCliente(Cliente cliente);
        void ExcluirCliente(string id);
    }
}
