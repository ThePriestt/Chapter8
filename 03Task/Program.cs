using System;

// Превърнете шестнайсетичните числа 2A3E, FA, FFFF, 5A0E9 в двоична и десетична бройна система. 

class Program
{
    static void Main()
    {
        //int sum = 2 * (int)Math.Pow(16, 3) + 10 * (int)Math.Pow(16, 2) + 3 * (int)Math.Pow(16, 1) + 14 * (int)Math.Pow(16, 0);
        //Console.WriteLine(sum);

        int sum = 0;
        string hex = "FA";
        int digit = 0;

        for (int i = 0; i < hex.Length; i++)
        {
            switch (hex[i])
            {
                case 'A':
                    digit = 10;
                    break;

                case 'B':
                    digit = 11;
                    break;

                case 'C':
                    digit = 12;
                    break;

                case 'D':
                    digit = 13;
                    break;

                case 'E':
                    digit = 14;
                    break;

                case 'F':
                    digit = 15;
                    break;

                default:
                    digit = int.Parse(hex[i].ToString());
                    break;
            }
            
            if (digit == 0)
            {
                continue;
            }
            sum += digit * (int)Math.Pow(16, hex.Length - 1 - i);
        }
        Console.WriteLine(sum);
    }
}

