using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class Teste
    {
        static void Main(String[] args)
        {
            Orcamento reforma = new Orcamento(500.0);

            Imposto novoImposto = new ICCC();
            Console.WriteLine(novoImposto.Calcula(reforma));
        }
    }
}
