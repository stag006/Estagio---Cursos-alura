using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap6
{
    class MensagemCliente : IMensagem
    {
        private string nome;
        public MensagemCliente(string nome)
        {
            this.nome = nome;
        }
        public void Envia()
        {
            Console.WriteLine("Enviando a mensagem por e-mail");
            Console.WriteLine("Mensagem para o cliente {0}", nome);
        }
        
        public string Formata()
        {
            return string.Format("Mensagem para o cliente");
        }
    }
}
