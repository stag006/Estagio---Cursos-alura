﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbertasOpenClosedEDependencyInversionPrinciples
{
    public class CalculadoraDePrecos
    {
        private ITabelaDePreco tabela;

        private IServicoDeEntrega entrega;

        public CalculadoraDePrecos(ITabelaDePreco tabela, IServicoDeEntrega entrega)
        {
            this.tabela = tabela;
            this.entrega = entrega;
        }        

        public double Calcula(Compra produto)
        {
            double desconto = this.tabela.DescontoPara(produto.Valor);
            double frete = this.entrega.Para(produto.Cidade);

            return produto.Valor * (1 - desconto) + frete;
        }
        
    }
}
