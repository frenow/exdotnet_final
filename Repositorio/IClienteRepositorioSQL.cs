using ProjetoDotNet2.Data;
using ProjetoDotNet2.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDotNet2.Repositorio
{
    public class IClienteRepositorioSQL : IClienteRepositorio
    {
        private ApplicationDbContext _contexto;
        public IClienteRepositorioSQL(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        List<Cliente> IClienteRepositorio.getClientes()
        {
            return _contexto.Cliente.ToList();
            //return _contexto.Cidade.Where(s => s.Id.ToString().Equals(id)).FirstOrDefault();
        }

        public List<Cliente> GetCliente()
        {
            return _contexto.Cliente.ToList();
        }

        public void AdicionarCliente(Cliente cliente)
        {
            this._contexto.Cliente.Add(cliente);
            this._contexto.Entry(cliente).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            this._contexto.SaveChanges();
        }

        public void AtualizaCliente(Cliente cliente)
        {
            _contexto.Cliente.Add(cliente);
            _contexto.Entry(cliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _contexto.SaveChanges();
        }

        public Cliente GetCliente(string id)
        {
            return _contexto.Cliente.Where(s => s.Id.ToString().Equals(id)).FirstOrDefault();
        }

        public void ExcluirCliente(string id)
        {
            Cliente cliente = GetCliente(id);
            this._contexto.Entry(cliente).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            this._contexto.SaveChanges();
        }
    }
}
