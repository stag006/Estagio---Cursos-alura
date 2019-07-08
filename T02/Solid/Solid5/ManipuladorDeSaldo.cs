using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid5
{
    class ManipuladorDeSaldo
    {
        public double Saldo { get; private set; }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
        public void Saca(double valor)
        {
            if (valor <=this.Saldo)
            {
                this.Saldo -= valor;
            }
            else
            {
                throw new ArgumentException();
            }             
        }
        
    }
}
