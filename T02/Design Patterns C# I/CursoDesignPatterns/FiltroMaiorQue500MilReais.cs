using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{

    public class FiltroMaiorQue500MilReais : Filtro
    {
        public FiltroMaiorQue500MilReais(Filtro outroFiltro) : base(outroFiltro) { }

        public FiltroMaiorQue500MilReais() : base() { }

        public override IList<Conta> Filtra(List<Conta> contas)
        {
            IList<Conta> filtrada = new List<Conta>();
            foreach (Conta c in contas)
            {
                if (c.Valor > 500000) filtrada.Add(c);
            }
            foreach (Conta c in proximo(contas))
            {
                filtrada.Add(c);
            }
            return filtrada;
        }
    }
}
