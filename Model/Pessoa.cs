using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoElevador.Model;

namespace ProjetoElevador.Model
{
    internal class Pessoa
    {
        public int andar { get; set; }
        public Pessoa(int a)
        {
            do
            {
                Random rnd = new Random();
                andar = rnd.Next(-1, Elevador.qtdeAndares);
                if (andar != a) { break; }
            } while (true);
            
        }
    }
}
