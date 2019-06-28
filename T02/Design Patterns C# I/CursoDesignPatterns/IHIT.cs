using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class IHIT : TemplateDeImpostoCondicional
    {
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            Ilist<String> noOrcamento = new List<String>();

            foreach (Item item in orcamento.Itens)
            {
                if (noOrcamento.contains(Item.Nome))
            return true;
                else
                    noOrcamento.Add(item.getNome);
            }
        }
    }
    protected override double MaximaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor * 0.13 + 100;
    }
    protected override double MinimaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor * (0.01 * orcamento.Itens.Count);
    }
}
}
