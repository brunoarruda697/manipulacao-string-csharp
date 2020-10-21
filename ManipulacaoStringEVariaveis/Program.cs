using System;
using System.Globalization;

namespace ManipulacaoStringEVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 23;
            double saldo = 10.35784;
            string nome = "Bruno";

            // **Placeholders**
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais", nome, idade, saldo);
            // dá pra usar arredondamento de float dentro das chaves.
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            // **Interpolação**
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            // **Concatenação**
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais ");
            // só da pra utilizar o objeto CultureInfo na forma de concatenação
        }
    }
}
