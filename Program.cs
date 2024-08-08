using System;
using ContaBanco;

class Program
{
    static void Main(string[] args)
    {
        ContaCorrente Cc = new ContaCorrente(1590, 1.000, 2.500);
        ContaPoupanca Cp = new ContaPoupanca(0956, 1.500, 0.5);
        Cc.Sacar(1.500);
        Console.WriteLine(Cc);
        Cp.AplicarRendimento();
        Console.WriteLine(Cp);
    }
}