

public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int conta = 100;
    public double saldo;


    //Toda FUNÇÃO deve ser colocada a primeira letra em maiúsculo e no verbo infinitivo.
    public bool Sacar(double valor)
    {
        //o this é uma palavra reservada, e neste nosso caso, ele está falando que 
        //estou acessando o saldo desta instancia.
        if (this.saldo < valor)
        {
            return false;
        }
        this.saldo -= valor;
        return true;
    }
    // estamos falando que essa função não retornará nada quando colocamos o void
    // quando usamos o void, o correto é falar que é um método
    // todos os outros seriam Função
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