﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        public IKCV() : base() { }

        public IKCV(Imposto outroImposto) : base(outroImposto) { }

        // classe continua aqui...
    }
}
