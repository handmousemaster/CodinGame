using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();
        int difference = -1;
        
        for (int i = 0; i < N; i++)
        {
            list.Add(int.Parse(Console.ReadLine()));
        }
        
        list.Sort();

        
        for(int i = 0; i < list.Count - 1; i++)
        {
            int diff = Math.Abs(list[i] - list[i+1]);
            if (difference < 0 || diff < difference)
            {
                difference = diff;
            }
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(difference);
    }
}