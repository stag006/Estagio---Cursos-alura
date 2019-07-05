using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid4
{
    class ProcessadorDeBoletos
    {
        public void Processa(List<Boleto> boletos, Fatura fatura)
        {


            foreach (Boleto boleto in boletos)
            {
                Pagamento pagamento = new Pagamento(boleto.Valor, MeioDePagamento.BOLETO);
                fatura.AdicionaPagamento(pagamento);
            }
        }
    }
}
