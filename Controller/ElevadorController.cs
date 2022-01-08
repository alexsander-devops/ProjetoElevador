using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoElevador.View;
using ProjetoElevador.Model;

namespace ProjetoElevador.Controller
{
    internal class ElevadorController
    {
        private static Elevador _elevator;
        private PainelElevador _painel;
        public static int qtdeAndares = _elevator.QtdeAndares;
        public ElevadorController()
        {
            _painel.IniciarElevador(_elevator);
        }

        public int QtdeAndares()
        {
            return _elevator.QtdeAndares;
        }
        public int pessoaEntrar(Pessoa pessoa)
        {
            _elevator.AddPessoa(pessoa);
            return _elevator.Pessoas;
        }
    }
}
