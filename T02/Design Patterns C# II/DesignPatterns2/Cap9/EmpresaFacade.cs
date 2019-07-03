using DesignPatterns2.Cap8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap9
{
    class EmpresaFacade
    {
        public Cliente BuscaCliente(string cpf)
        {
            return new ClienteDAO().BuscaPorCpf(cpf);
        }
        public Fatura CriaFatura(Cliente cliente, double valor)
        {
            return new Fatura(cliente, valor);
        }
        public Cobranca GeraCobranca(Tipo tipo, Fatura fatura)
        {
            GeraCobranca cobranca = new GeraCobranca(tipo, fatura);
            cobranca.Emite();
            return cobranca;
        }
        public ContatoCliente FazContato(Cliente cliente, Cobranca cobranca)
        {
            ContatoCliente contato = new contatoCliente(cliente, cobranca);
            contato.Dispara();
            return contato;
        }
    }
}
