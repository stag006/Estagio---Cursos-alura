using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoArthur = new ContaCorrente();

            contaDoArthur.titular = "Arthur";
            contaDoArthur.agencia = 863;
            contaDoArthur.numero = 863452;
            contaDoArthur.saldo = 100;

            Console.WriteLine(contaDoArthur.titular);
            Console.WriteLine("Agnência: " + contaDoArthur.agencia);
            Console.WriteLine("Numero: " + contaDoArthur.numero);
            Console.WriteLine("Saldo" + contaDoArthur.saldo);

            contaDoArthur.saldo += 200;
            Console.WriteLine(contaDoArthur.saldo);


            Console.ReadLine();
        }
    }
}
