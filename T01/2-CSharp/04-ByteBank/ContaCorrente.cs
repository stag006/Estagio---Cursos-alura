



public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        
            this.saldo -= valor;
            return true;        
    }

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (this.saldo < valor)
        {
            return false;
        }

        this.saldo -= valor;
        contaDestino.Depositar(valor);
        return true;
    }
}



/* APRENDEMOS:
 * como definir métodos com parâmetros e retorno;
como retornar algo usando a palavra chave return antes da expressão do resultado;
o uso do return para retornar antecipadamente a execução de um método void;
como usar a referência this para acessar um atributo;
que podemos passar uma referência como parâmetro do método;
métodos são chamadas a partir da referência usando o operador ...
 */
