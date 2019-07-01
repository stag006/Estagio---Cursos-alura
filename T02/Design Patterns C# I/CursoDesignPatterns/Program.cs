using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            NotaFiscalBuilder criador = new NotaFiscalBuilder();
            criador
                .ParaEmpresa("Caelum Ensino e Inovacao")
                .ComCnpj("23.456.789/0001-12")
            
                .ComItem(new ItemDaNotaBuilder("item 1", 100.0))
                .ComItem(new ItemDaNotaBuilder("item 2", 200.0))
                .NaDataAtual()
                .ComObservacoes("uma obs qualquer");


            NotaFiscal nf = criador.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);
            Console.ReadKey();
        }
    }
}
