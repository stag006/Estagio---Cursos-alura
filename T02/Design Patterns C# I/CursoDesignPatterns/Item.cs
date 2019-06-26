using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Item
    {
        public string nome { get; private set; }
        public double Valor { get; private set; }
        public Item(String nome, double valor)
        {
            this.nome = nome;
            this.Valor = valor;
        }
    }
}
