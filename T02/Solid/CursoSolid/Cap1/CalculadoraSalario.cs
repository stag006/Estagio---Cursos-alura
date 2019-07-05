﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoSolid.Cap1
{
   public class CalculadoraSalario
    {
        public double calcula(Funcionario funcionario)
        {
            if (funcionario.Cargo is Desenvolvedor)
            {
                return dezOuVintePorcento(funcionario);
            }

            if (funcionario.Cargo is Dba || funcionario.Cargo is Tester)
            {
                return quinzeOuVinteCincoPorcento(funcionario);
            }

            throw new Exception("funcionario invalido");
        }

        private double dezOuVintePorcento(Funcionario funcionario)
        {
            if (funcionario.SalarioBase > 3000.0)
            {
                return funcionario.SalarioBase * 0.8;
            }
            else
            {
                return funcionario.SalarioBase * 0.9;
            }
        }

        private double quinzeOuVinteCincoPorcento(Funcionario funcionario)
        {
            if (funcionario.SalarioBase > 2000.0)
            {
                return funcionario.SalarioBase * 0.75;
            }
            else
            {
                return funcionario.SalarioBase * 0.85;
            }
        }
    }
}
