using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        public ICPP() : base() { }
        public ICPP(Imposto outroImposto) : base(outroImposto) { }

        // classe continua aqui...
    }
}
