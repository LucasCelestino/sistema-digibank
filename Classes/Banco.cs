using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace digibank.Classes
{
    public class Banco
    {
        public Banco()
        {
            this.nomeBanco = "DigiBank";
            this.codigoBanco = "027";
        }

        public string nomeBanco {get; private set;}
        public string codigoBanco {get; private set;}
    }
}