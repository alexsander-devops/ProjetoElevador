using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    internal class Elevador : IElevador
    {
        public static int capacidade { get; set; }
        public static int qtdeAndares { get; set; }

        public int andar { get; set; }

        public List<Pessoa> ltAtual { get; set; }

        public void inicializar(int lotacaoMax, int andares)
        {
            try 
            {
                capacidade = lotacaoMax;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.GetType().FullName);
                Console.WriteLine(ex.Message);
            }

            try 
            {
                qtdeAndares = andares;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.GetType().FullName);
                Console.WriteLine(ex.Message);
            }
        }

        public int descer()
        {
            throw new NotImplementedException();
        }

        public int entrar()
        {
            throw new NotImplementedException();
        }

        

        public int sair()
        {
            throw new NotImplementedException();
        }

        public int subir()
        {
            throw new NotImplementedException();
        }
    }
}
