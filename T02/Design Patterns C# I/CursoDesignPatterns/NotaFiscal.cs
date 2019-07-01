using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class NotaFiscalBuilder
    {
        private String RazaoSocial { get; set; }
        private String Cnpj { get; set; }

        private List<ItemDaNota> todosItens = new ArrayList<ItemDaNota>();
        private double ValorBruto { get; set; }
        private double Impostos { get; set; }
        private String Observacoes { get; set; }
        private Calendar Data { get; set; }

        public NotaFiscalBuilder()
        {
            this.Data = DateTime.Now;
        }

        public NotaFiscalBuilder NaData(DateTime novaData)
        {
            this.Data = novaData;

            return this;
        }

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, ValorBruto,
                                Impostos, TodosItens, Observacoes);
        }

        // outros métodos aqui
    }
}
