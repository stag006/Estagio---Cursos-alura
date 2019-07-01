using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class TestedeImpostos
    {
        public static void Main(String[] args)
        {

                   
            Imposto impostos = new ImpostoMuitoAlto(new ICMS());

            Orcamento orcamento = new Orcamento(500.0);

            Console.WriteLine(impostos.Calcula(orcamento));
        }
    }
}
}
