using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class TestaCorrente
    {
        static void Main(String[] args)
        {
            Imposto impostos = new ISS(new ICMS());

            Orcamento orcamento = new Orcamento(500.0);

            Console.WriteLine(impostos.Calcula(orcamento));
            
        }
    }
}
