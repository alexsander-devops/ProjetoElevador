using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoElevador.Model;
using ProjetoElevador.Controller;

namespace ProjetoElevador.Model
{
    public class Pessoa
    {
        private int andar;
        public int Andar
        {
            get { return andar; }
        }

        // Ao instanciar um objeto pessoa
        // devemos passar como parâmetro
        // um inteiro que corresponde 
        // ao andar em que o elevador está.
        public Pessoa(int a)
        {
            int limiteAndares = Elevador.QtdeAndares; 
            
            do
            {
                Random rnd = new Random();
                andar = rnd.Next(0, limiteAndares);
                if (andar != a) { break; }
            } while (true);
            
        }


    }
}
