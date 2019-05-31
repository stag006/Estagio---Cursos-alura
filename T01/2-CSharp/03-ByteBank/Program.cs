using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {        
            // Criamos uma conta para Gabriela costa
            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;

            ContaCorrente contaDoArthur = new ContaCorrente();
            contaDoArthur.titular = "Arthur";
            contaDoArthur.agencia = 863;
            contaDoArthur.numero = 863452;

            Console.WriteLine("Igualdade de tipo de referência: " + (contaDoArthur == contaDaGabrielaCosta));
            // É falso porque a iguadale é do tipo de referencia, e sempre vai ser falso.


            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeMaisUmaVez));
            // Nesse caso a igaudade das variaveis eram verdadeiro porque era do tipo valor!

            /* Iremos igualar as duas variaveis do tipo contaDaabrielaCosta = contaDoArthur
             * Fazendo isso as duas contas a contaDoArthur = contaGabrielaCosta
              */ 
            contaDaGabrielaCosta = contaDoArthur;
            Console.WriteLine(contaDaGabrielaCosta == contaDoArthur);

            contaDoArthur.saldo += 400;
            Console.WriteLine(contaDoArthur.saldo);
            Console.ReadLine();

        }
    }
}
