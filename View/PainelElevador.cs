using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoElevador.Model;

namespace ProjetoElevador.View
{
    // Essa classe será responsável por exibir 
    // as informações do elevador na tela
    internal class PainelElevador
    {
        // Esse método solicita as informações iniciais
        // que são: quantidade de andares do prédio e
        // capacidade máxima do elevador
        public void IniciarElevador(Elevador e)
        {
            Console.WriteLine("Digite a quantidade de andares do prédio: ");
            int andares = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a lotação máxima do elevador: ");
            int capacidade = int.Parse(Console.ReadLine());

            e.Inicializar(capacidade, andares);
        }
    }
}
