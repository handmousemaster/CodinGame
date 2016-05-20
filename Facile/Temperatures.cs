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
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string temps = Console.ReadLine(); // the n temperatures expressed as integers ranging from -273 to 5526

        string[] inputs = temps.Split(' ');
        
        int minTemp;
        
        if (n == 0)
        {
            minTemp = 0;
        }
        else
        {
            minTemp = int.Parse(inputs[0]);
        }
        
        for(int i = 1; i < n; i++)
        {
            int temp = int.Parse(inputs[i]);
            if (Math.Abs(temp) < Math.Abs(minTemp))
            {
                minTemp = temp;
            }
            else if (Math.Abs(temp) == Math.Abs(minTemp))
            {
                if(temp > minTemp)
                {
                    minTemp = temp;
                }
            }
        }


        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");


        Console.WriteLine(minTemp);
    }
}