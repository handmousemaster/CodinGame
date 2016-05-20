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
        string LON = Console.ReadLine();
        string LAT = Console.ReadLine();
        int N = int.Parse(Console.ReadLine());
        
        double minDistance = 0;
        string name = "";
        double longitude = GetDouble(LON);
        double latitude = GetDouble(LAT);
        
        for (int i = 0; i < N; i++)
        {
            string DEFIB = Console.ReadLine();
            string[] inputs = DEFIB.Split(';');
            double tempDistance = GetDistance(latitude, GetDouble(inputs[5]), longitude, GetDouble(inputs[4]));
            
            if (name == "" || minDistance > tempDistance)
            {
                name = inputs[1];
                minDistance = tempDistance;
            }
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(name);
    }
    
    static double GetDouble(string val)
    {
        return Double.Parse(val.Replace(",", "."));
    }
    
    static double GetDistance(double latA, double latB, double lonA, double lonB)
    {
        double x = (lonB - lonA) * Math.Cos((latA + latB)/2);
        double y = latB - latA;
        return Math.Sqrt(x*x + y*y)*6371;
    }

}