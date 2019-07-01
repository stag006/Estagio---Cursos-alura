﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class Finalizado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento) { }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Não posso mudar mais, já estou finalizado!");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Não posso mudar mais, já estou finalizado!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Não posso mudar mais, já estou finalizado!");
        }
    }
}
