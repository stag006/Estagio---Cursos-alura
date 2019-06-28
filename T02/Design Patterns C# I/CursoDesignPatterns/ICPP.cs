﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class ICPP : TamplateDeImpostoCondicional
    {
        public bool DeveUsarMaximaTaaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;            
        }
        public double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }
        public double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
