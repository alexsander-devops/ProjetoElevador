using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoElevador.Model;
using ProjetoElevador.Controller;

namespace ProjetoElevador.Model
{
    internal class Pessoa
    {
        private int andar;

        private int andaresQtde = ElevadorController.qtdeAndares;
        public Pessoa(int a)
        {
            do
            {
                Random rnd = new Random();
                andar = rnd.Next(-1, andaresQtde);
                if (andar != a) { break; }
            } while (true);
            
        }

        public int Andar()
        {
            return andar;
        }

        public void limiteAndares(int n)
        {
            andaresQtde = n;
        }
    }
}
