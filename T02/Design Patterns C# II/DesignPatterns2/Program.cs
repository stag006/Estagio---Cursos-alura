using DesignPatterns2.Cap1;
using DesignPatterns2.Cap2;
using DesignPatterns2.Cap3;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            Contrato c = new Contrato(DateTime.Now, "victor", TipoContrato.Novo);

            Console.WriteLine(c.Tipo);

            c.Avanca();

            Console.WriteLine(c.Tipo);
        }
    }
}
