﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid5
{
    class ContaEstudante : ContaComum
    {
        public int Milhas { get; private set; }

        public override void Deposita(double valor)
        {
            base.Deposita(valor);
            this.Milhas += (int)valor;
            throw new ArgumentException();
        }
        public override void somaInvestimento()
        {
            throw new Exception("Uma conta de estudante nao possui rendimentos");
        }
    }
}
