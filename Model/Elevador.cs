﻿using System;
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

        public void Inicializar(int capacidade, int andares)
        {
            Capacidade = capacidade;
            QtdeAndares = andares;
        }

        public int Subir()
        {
            throw new NotImplementedException();
        }
        
        public int Descer()
        {
            throw new NotImplementedException();
        }

        public int Entrar()
        {
            throw new NotImplementedException();
        }

        public int Sair()
        {
            throw new NotImplementedException();
        }

    }
}
