using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    public class Elevador : IElevador
    {
        // Atributos da classe Elevador
        private int capacidade;
        private int andar = 0;
        private List<Pessoa> pessoas = new List<Pessoa>();
        private static int qtdeAndares = 0;

        public int Capacidade
        {
            get { return capacidade; }
            set { capacidade = value; }
        }

        public static int QtdeAndares
        {
            get { return qtdeAndares; } 
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

        public void Inicializar(int capacidade, int andares)
        {
            Capacidade = capacidade;
            qtdeAndares = andares;
        }

        // Incrementa o andar em que o elevador está
        // e ao incrementar, verifica se alguma pessoa
        // solicitou o andar em que ele está.
        public int Subir()
        {
            if (andar < qtdeAndares) {
                andar++;
            } 

            foreach (Pessoa pessoa in pessoas)
            {
                if (pessoa.Andar == andar)
                    Sair(pessoa);
            }

            return andar;
        }
        
        public int Descer()
        {
            throw new NotImplementedException();
        }

        // O método recebe como parâmetro
        // um objeto do tipo pessoa, adicionando-o 
        // às pessoas dentro do elevador  
        // e retorna a quantidade de pessoas.
        public int Entrar(Pessoa pessoa)
        {
            try
            {
                pessoas.Add(pessoa);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }

            return Pessoas;
        }

        // O método recebe como parâmetro
        // um objeto do tipo pessoa e 
        // o retira da quantidade de
        // pessoas dentro do elevador.
        public int Sair(Pessoa pessoa)
        {
            try
            {
                pessoas.Remove(pessoa);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }

            return Pessoas;
        }

    }
}
