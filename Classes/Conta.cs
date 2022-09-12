using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using digibank.Contratos;

namespace digibank.Classes
{
    public abstract class Conta : Banco, ContaInterface
    {
        public Conta()
        {
            this.numeroAgencia = "001";
            Conta.numeroContaSequencial++;
        }

        public double saldo {get; protected set;}
        public string numeroAgencia {get; private set;}
        public string numeroConta {get; protected set;}

        public static int numeroContaSequencial {get; private set;}
        public void deposita(double valor)
        {
            this.saldo += valor;
        }
        public bool saca(double valor)
        {
            if(valor > this.consultaSaldo())
            {
                return false;
            }

            this.saldo -= valor;
            return true;
        }
        public double consultaSaldo()
        {
            return this.saldo;
        }
        public string getCodigoBanco()
        {
            return this.codigoBanco;
        }
        public string getNumeroAgencia()
        {
            return this.numeroAgencia;
        }
        public string getNumeroConta()
        {
            return this.numeroConta;
        }
    }
}