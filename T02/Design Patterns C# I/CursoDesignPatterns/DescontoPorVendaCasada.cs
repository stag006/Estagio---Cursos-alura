using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class DescontoPorVendaCasada : Desconto
    {
        public Desconto Proximo { get; set; }
        public double Calcula(Orcamento orcamento)
        {
            if (aconteuVendaCasadaEm(orcamento))
            {
                return orcamento.Valor * 0.05;
            }
            else
            {
                return Proximo.Calcula(orcamento);
            }
        }
        private bool aconteceuVendaCasadaEm(Orcamento orcamento)
        {
            return existe("CANETA", orcamento) && existe("LAPIS", orcamento);
        }

        private bool existe(String nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem))
                {
                    return true;
                }
                return false;
            }
        }
    }
}
