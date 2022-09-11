using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace digibank.Classes
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente()
        {
            this.numeroConta = "00" + Conta.numeroContaSequencial;
        }
    }
}