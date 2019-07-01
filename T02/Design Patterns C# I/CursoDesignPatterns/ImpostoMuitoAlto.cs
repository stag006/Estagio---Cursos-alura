using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class ImpostoMuitoAlto : Imposto
    {
        public ImpostoMuitoAlto(Imposto imposto) : base(imposto) { }

        public ImpostoMuitoAlto() : base() { }

        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalculaOutroImposto(orcamneto);
        }
    }
}
