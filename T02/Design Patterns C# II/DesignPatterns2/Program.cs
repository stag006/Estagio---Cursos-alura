using DesignPatterns2.Cap1;
using DesignPatterns2.Cap2;
using DesignPatterns2.Cap3;
using DesignPatterns2.Cap4;
using DesignPatterns2.Cap5;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            //(1 + 10) + (20 - 10)

            IExpressao Esquerda = new Soma(new Soma(new Numero(1), new Numero(100)), new Numero(10));
            IExpressao Direita = new Subtracao(new Numero(20), new Numero(10));
            IExpressao soma = new Soma(Esquerda, Direita);

            Console.WriteLine(soma.Avalia());
            ImpressoraVisitor impressora = new ImpressoraVisitor();
            soma.Aceita(impressora);
        }   
    }
}
