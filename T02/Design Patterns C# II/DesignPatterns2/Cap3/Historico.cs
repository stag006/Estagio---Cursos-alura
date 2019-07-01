using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap3
{
    public class Historico
    {
        private IList<Estado> Estados = new List<Estado>();

        public void Adiciona(Estado estado)
        {
            this.Estados.Add(estado);
        }
        public Estado Pega(int indice)
        {
            return Estados[indice]; // No exercicio do alura ele coloca o "indice" para "index".....obs; ficar atento.. no mais tudo ok!
        }
    }
}
