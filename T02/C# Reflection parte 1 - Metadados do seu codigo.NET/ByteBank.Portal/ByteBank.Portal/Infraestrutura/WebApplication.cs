using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Portal.Infraestrutura
{
    public class WebApplication
    {
        // http://bytebank.com/ ?
        // http://localhost:80/ ?
        public void Iniciar()
        {
            var httpListener = new HttpListener();

            httpListener.Start();

        }
    }
}
