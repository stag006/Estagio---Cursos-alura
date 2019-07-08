﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid5
{
    class ContaComum
    {
        public double Saldo { get; protected set; }

        public ContaComum()
        {
            this.Saldo = 0;
        }

        public virtual void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Saca(double valor)
        {
            if (valor <= this.Saldo)
            {
                this.Saldo -= valor;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public virtual void somaInvestimento()
        {
            this.Saldo += this.Saldo * 0.01;
        }
    }
}
