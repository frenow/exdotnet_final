using ProjetoDotNet2.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDotNet2.Repositorio
{
    public interface IDepoimentoRepositorio
    {
        List<Depoimento> getDepoimento();
        void AdicionarDepoimento(Depoimento depoimento);
        Depoimento GetDepoimento(string id);
        void AtualizaDepoimento(Depoimento depoimento);
        void ExcluirDepoimento(string id);
    }
}
