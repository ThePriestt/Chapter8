using System;

// Превърнете числата 151, 35, 43, 251, 1023 и 1024 в двоична бройна система.

class Program
{
    static void Main()
    {
        int n = 1023;
        //Console.WriteLine(n % 2);
        //Console.WriteLine(n / 2);
        //n = n / 2;
        //Console.WriteLine(n);
        //Console.WriteLine(n % 2);
        //n = n / 2;
        //Console.WriteLine(n % 2);

        while (n >= 2)
        {
            Console.WriteLine(n % 2);
            n = n / 2;
        }
        Console.WriteLine(n);
    }
}

