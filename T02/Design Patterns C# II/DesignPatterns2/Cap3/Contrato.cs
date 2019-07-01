using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap3
{
    class Contrato
    {
        public DateTime Data { get; private set; }

        public string Cliente { get; private set; }

        public TipoContrato Tipo { get; private set; }
    }
}
