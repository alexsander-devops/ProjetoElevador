using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoElevador.View;
using ProjetoElevador.Model;

namespace ProjetoElevador.Controller
{
    public class ElevadorController
    {
        private Elevador _elevator = new Elevador();
        private PainelElevador _painel;
        
        public ElevadorController()
        {
            _painel = new PainelElevador(_elevator);
        }
    }
}
