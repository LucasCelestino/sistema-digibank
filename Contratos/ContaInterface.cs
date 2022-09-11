using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace digibank.Contratos
{
    public interface ContaInterface
    {
        void deposita(double valor);
        bool saca(double valor);
        double consultaSaldo();
        string getCodigoBanco();
        string getNumeroAgencia();
        string getNumeroConta();
    }
}