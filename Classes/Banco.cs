using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace digibank.Classes
{
    public class Banco
    {
        public Banco(string nomeBanco, string codigoBanco)
        {
            this.nomeBanco = nomeBanco;
            this.codigoBanco = codigoBanco;
        }

        public string nomeBanco {get; private set;}
        public string codigoBanco {get; private set;}
    }
}