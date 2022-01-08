using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    internal interface IElevador
    {
        void inicializar(int lotacaoMax, int andares);
            
        int subir();

        int descer();

        int entrar();

        int sair();

    }
}
