using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using digibank.Contratos;

namespace digibank.Classes
{
    public class Pessoa
    {
        public string nome {get; private set;}
        public string cpf {get; private set;}
        public string senha {get; private set;}
        public ContaInterface contaInterface {get; set;}

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setCPF(string cpf)
        {
            this.cpf = cpf;
        }

        public void setSenha(string senha)
        {
            this.senha = senha;
        }
    }
}