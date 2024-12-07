using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

class Program
{
    public static void Main(string[] args)
    {
        int x = 1534236469;
        Console.WriteLine(Reverse(x));
        Console.WriteLine("MaxValue  " + int.MaxValue + "  int.MinValue " + int.MinValue);
    }
    public static int Reverse(int x)
    {

        int result = 0;

        while (x != 0)

        {
            int sonBasamak = x % 10;
            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && sonBasamak > 7))
                return 0; // Pozitif taşma
            if (result < int.MinValue / 10 || (result == int.MinValue / 10 && sonBasamak < -8))
                return 0; // Negatif taşma
            result = result * 10 + sonBasamak;
            x /= 10;
        }
        return result;
    }
}




