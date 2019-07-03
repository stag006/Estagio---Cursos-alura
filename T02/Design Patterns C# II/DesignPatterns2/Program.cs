using DesignPatterns2.Cap1;
using DesignPatterns2.Cap2;
using DesignPatterns2.Cap3;
using DesignPatterns2.Cap4;
using DesignPatterns2.Cap5;
using DesignPatterns2.Cap6;
using DesignPatterns2.Cap7;
using DesignPatterns2.Cap8;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            cliente.Nome = "victor";
            cliente.Endereco = "Rua Vergueiro";
            cliente.DatadeNascimento = DateTime.Now;

            XmlSerializer serializer = new XmlSerializer(cliente.GetType());
            StringWriter Writer = new StringWriter();
            serializer.Serialize(Writer, cliente);
            String xml = Writer.ToString();

            Console.WriteLine(xml);
        }
    }
}
