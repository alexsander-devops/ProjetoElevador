using ProjetoElevador.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Controller
{
    internal class ElevadorController
    {
        private Elevador _elevator;
        public ElevadorController(Elevador elevador)
        {
            elevador.inicializar(5, 12);
            elevador.andar = 0;
        }

        public int pessoaEntrar(Elevador elevador, Pessoa pessoa)
        {
            elevador.ltAtual.Add(pessoa);
            return elevador.ltAtual.Count;
        }
    }
}
