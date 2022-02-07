using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando um objeto (instancia) (chamando a classe ContaCorrente) new ContaCorrente
            //A contaDaGabriela está apontando para a classe ContaCorrente
            ContaCorrente contaDaGabriela = new ContaCorrente();

            //Estou acessando as variáveis da classe.
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.conta = 863452;
            contaDaGabriela.saldo = 100;
            Console.WriteLine("Nome do Titular " + contaDaGabriela.titular);
            Console.WriteLine("Agencia do Titular " + contaDaGabriela.agencia);
            Console.WriteLine("Conta do Titular " + contaDaGabriela.conta);
            Console.WriteLine("Saldo do Titular " + contaDaGabriela.saldo);

            contaDaGabriela.saldo += 200;
            Console.WriteLine("Saldo do Titular " + contaDaGabriela.saldo);

            Console.ReadLine();

        }
    }
}
