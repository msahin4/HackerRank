using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args) 
    {
        List<int> a = new List<int>();
        a = [9, 18 ,17 ,5,7,12,];
        int wall = a.Count;
        int swapCount = 0;
        for (int i = 0; i < wall - 1; i++)
        {
            for (int j = 0; j < wall - i - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                    swapCount++;
                }
            }
        }
        Console.WriteLine("Array is sorted in " + swapCount + " swaps.");
        Console.WriteLine("First Element: " + a[0]);
        Console.WriteLine("Last Element: " + a[wall - 1]);

    }
}
