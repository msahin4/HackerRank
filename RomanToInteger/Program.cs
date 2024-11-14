using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args) 
    {
        Console.WriteLine(RomanToInt("XXVI"));
        


    }
        public static int RomanToInt(string s)
    {
        int sum = 0;
        for (int j = 0; j < s.Length - 1; j++)
        {
            if (convert(s[j]) >= convert(s[j + 1]))
                sum += convert(s[j]);
            else
                sum -= convert(s[j]);
        }
        sum += convert(s[s.Length - 1]);
        return sum;
    }


        public static int convert(char s)
    {
        if (s == 'I')
            return 1;
        else if (s == 'V')
            return 5;
        else if (s == 'X')
            return 10;
        else if (s == 'L')
            return 50;
        else if (s == 'C')
            return 100;
        else if (s == 'D')
            return 500;
        else if (s == 'M')
            return 1000;
        else
            return 0;

    }
}
