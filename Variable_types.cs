using System;
using System.Globalization;

namespace Course { 
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine("Bom dia!");
            Console.WriteLine("Boa Tarde!");
            Console.WriteLine("Boa Noite");
            Console.WriteLine("--------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F3"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            // PlaceHolder
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:f2} reais", nome,idade,saldo);

            // Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:f2} reais");

            // Concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais ");
        }
    }
}
