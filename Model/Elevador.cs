using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    internal class Elevador : IElevador
    {
        // Atributos da classe Elevador
        private int capacidade;
        private int qtdeAndares;
        private int andar;
        private List<Pessoa> pessoas = new List<Pessoa>();

        public int Capacidade
        {
            get { return capacidade; }
            set { capacidade = value; }
        }

        public int QtdeAndares
        {
            get { return qtdeAndares; }
            set { qtdeAndares = value; }
        }

        public int Andar
        {
            get { return andar; }
            set { andar = value; }
        }

        public int Pessoas
        {
            get { return pessoas.Count; }
        }

        public void AddPessoa(Pessoa p)
        {
            pessoas.Add(p);
        }
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
