using System;

namespace strategyImposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto icms = new ICMS();
            Imposto iss = new ISS();
            
            Orcamento orcamento = new Orcamento(500);

            Console.WriteLine(iss.Calcula(orcamento));

            Console.WriteLine(icms.Calcula(orcamento));
        }
    }
}
