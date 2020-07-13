using ProjetoDotNet2.Data;
using ProjetoDotNet2.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDotNet2.Repositorio
{
    public class IDepoimentoRepositorioSQL : IDepoimentoRepositorio
    {
        private ApplicationDbContext _contexto;
        public IDepoimentoRepositorioSQL(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }
        public void AdicionarDepoimento(Depoimento depoimento)
        {
            this._contexto.Depoimento.Add(depoimento);
            this._contexto.Entry(depoimento).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            this._contexto.SaveChanges();
        }

        public void AtualizaDepoimento(Depoimento depoimento)
        {
            _contexto.Depoimento.Add(depoimento);
            _contexto.Entry(depoimento).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _contexto.SaveChanges();
        }

        public void ExcluirDepoimento(string id)
        {
            Depoimento depoimento = GetDepoimento(id);
            this._contexto.Entry(depoimento).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            this._contexto.SaveChanges();
        }

        public List<Depoimento> getDepoimento()
        {
            return _contexto.Depoimento.ToList();
        }

        public Depoimento GetDepoimento(string id)
        {
            return _contexto.Depoimento.Where(s => s.Id.ToString().Equals(id)).FirstOrDefault();
        }
    }
}
