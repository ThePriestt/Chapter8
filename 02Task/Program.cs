using System;

// Превърнете числото 1111010110011110(2) в шестнадесетична и в десетична бройна система. 

class Program
{
    static void Main()
    {
        //int sum = 1 * (int)Math.Pow(2, 15) + 1 * (int)Math.Pow(2, 14) + 1 * (int)Math.Pow(2, 13) + 1 * (int)Math.Pow(2, 12) + 1 * (int)Math.Pow(2, 10) + 1 * (int)Math.Pow(2, 8);
        //Console.WriteLine(sum);  

        int sum = 0;
        string number = "1111010110011110";
        int digit = 0;

        for (int i = 0; i < number.Length; i++)
        {
            digit = int.Parse(number[i].ToString());
            if (digit == 0)
            {
                continue;
            }
            sum += digit * (int)Math.Pow(2, number.Length - 1 - i);
        }
        Console.WriteLine(sum);
    }
}

