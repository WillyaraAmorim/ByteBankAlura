using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.conta = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.conta = 863452;

            //aqui estamos vendo que a referencia que ambas as "Contas" ela não será iguais
            //pois trata-se da referencia da memória.
            //Sendo assim, por apontar o Endereço da memória, o valor será falso.
            Console.WriteLine("Igualdade do tipo de referencia: " + (contaDaGabriela == contaDaGabrielaCosta));

            //aqui demonstra que a igualdade será true, pois estamos falando do valor que há nas variaveis
            int idade = 27;
            int idadeMaisUmaVez = 27;
            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeMaisUmaVez));

            //aqui passa a ser verdadeiro pois ambas uma referencia está recebendo a outra
            //logo elas serão equivalentes;
            contaDaGabriela = contaDaGabrielaCosta;
            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);

            //ambas as contas por estarem apontando para a mesma referencia da memória
            //receberão o valor de 300
            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaGabrielaCosta.saldo);

            Console.ReadLine ();
        }
    }
}
