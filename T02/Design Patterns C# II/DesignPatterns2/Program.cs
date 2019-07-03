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
            String cpf = "1234";

            Cliente cliente = new ClienteDAO().BuscaPorCpf(cpf);

            Fatura fatura = new Fatura(cliente, 5000);

            Cobranca cobranca = new Cobranca(TipoContrato.Boleto, fatura);
            cobranca.Emite();

            ContatoCliente contato = new ContatoCliente(cliente, cobranca);
            contato.Dispara();
        }
    }
}
