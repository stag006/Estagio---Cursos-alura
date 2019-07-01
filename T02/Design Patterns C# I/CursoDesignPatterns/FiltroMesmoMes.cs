using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class FiltroMesmoMes : Filtro
    {
        public FiltroMesmoMes(Filtro outroFiltro) : base(outroFiltro) { }

        public FiltroMesmoMes() : base() { }

        public override IList<Conta> Filtra(List<Conta> contas)
        {
            IList<Conta> filtrada = new List<Conta>();
            foreach (Conta c in contas)
            {
                if (c.DataAbertura.Month == DateTime.Now.Month &&
                  c.DataAbertura.Year == DateTime.Now.YEAR)
                {
                    filtrada.add(c);
                }
            }

            foreach (Conta c in proximo(contas))
            {
                filtrada.Add(c);
            }
            return filtrada;
        }
    }
}
