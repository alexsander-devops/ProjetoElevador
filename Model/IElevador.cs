using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    public interface IElevador
    {
        void Inicializar(int lotacaoMax, int andares);
            
        int Subir();

        int Descer();

        int Entrar(Pessoa pessoa);

        int Sair(Pessoa pessoa);

    }
}
