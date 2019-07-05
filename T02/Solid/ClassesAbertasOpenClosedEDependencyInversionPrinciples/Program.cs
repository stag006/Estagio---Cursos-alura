using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbertasOpenClosedEDependencyInversionPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Compra compra = new Compra(500, "sao paulo");
            CalculadoraDePrecos calc = new CalculadoraDePrecos(new TabelaDePrecoPadrao(), new Transportadora());

            double resultado = calc.Calcula(compra);

            Console.WriteLine("O preco da compra e : " + resultado);
        }
    }
}
