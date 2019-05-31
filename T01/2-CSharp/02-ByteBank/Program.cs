using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Gabriela";
            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.agencia);
            Console.WriteLine(conta.saldo); // Lembrando que nós podemos alterar o valor dor saldo aqui no program.cs, nesse caso mudando o saldo para 100 no ContaCorrente!

            // Estaremos agora mudando o valor do saldo e acrescentando masi 500 reais.

            conta.saldo += 500;
            Console.WriteLine(conta.saldo);

            Console.ReadLine();
        }
    }
}
