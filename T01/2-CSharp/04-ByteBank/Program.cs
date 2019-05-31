using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);

            contaDoBruno.Sacar(50);

            Console.WriteLine(contaDoBruno.saldo);
            

            //* Podemos expressaro código numa expressão booleana


            ContaCorrente contaDoArthur = new ContaCorrente();

            contaDoBruno.titular = "Arthur";

            Console.WriteLine(contaDoArthur.saldo);

            bool resultadoSaque = contaDoArthur.Sacar(500);

            Console.WriteLine(contaDoArthur.saldo);
            Console.WriteLine(resultadoSaque);

            contaDoArthur.Depositar(500);
            Console.WriteLine(contaDoArthur.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Arthur";

            Console.WriteLine("Saldo do Arthur: " + contaDoArthur.saldo);
            Console.WriteLine("Saldo do Gabriela: " + contaDaGabriela.saldo);

            bool resultadoTransferencia = contaDoArthur.Transferir(2000, contaDaGabriela);

            Console.WriteLine("Saldo do Arthur: " + contaDoArthur.saldo);
            Console.WriteLine("Saldo do Gabriela: " + contaDaGabriela.saldo);

            Console.WriteLine("Resultado transferencia: "  + resultadoTransferencia);

            contaDaGabriela.Transferir(100, contaDoArthur);

            Console.WriteLine("Saldo do Arthur: " + contaDoArthur.saldo);
            Console.WriteLine("Saldo do Gabriela: " + contaDaGabriela.saldo);

            Console.Read();
        }
    }
}
