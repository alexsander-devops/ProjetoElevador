using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoElevador.Model;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elevador.qtdeAndares = 12;
            Elevador e = new Elevador();
            e.andar = 0;
            Pessoa p = new Pessoa(e.andar);
            Console.WriteLine("O andar que a pessoa escolheu é: {0}",p.andar);
            Console.ReadLine();
        }
    }
}
