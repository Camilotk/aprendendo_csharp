using System;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList<int> numeros = new MyArrayList<int>();
            numeros.add(5);
            numeros.add(15);
            numeros.add(89);
            numeros.add(24);
            numeros.add(789);
            numeros.add(963);
            numeros.add(856);
            numeros.add(753);
            numeros.add(7985);

            Console.WriteLine(numeros.get(0));
            Console.WriteLine(numeros.get(1));
            Console.WriteLine(numeros.get(2));
            Console.WriteLine(numeros.get(6));
            Console.WriteLine(numeros.get(7));
            Console.WriteLine(numeros.get(8));
        }
    }
}
