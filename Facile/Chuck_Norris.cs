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
        string MESSAGE = Console.ReadLine();

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        
        string binaryString = "";
        foreach (char c in MESSAGE)
        {
            string temp = Convert.ToString(Convert.ToInt32(c), 2);
            while(temp.Length < 7)
            {
                temp = "0" + temp;
            }
    
            binaryString += temp;
        }
    
        string output = "";
        string current = "";
        
        Console.Error.WriteLine(binaryString);
            
        for(int i = 0; i < binaryString.Length; i++)
        {
            string temp = binaryString.Substring(i, 1);
            if (current != temp)
            {
                output += " ";
                if (temp == "0")
                {
                    output += "00 ";
                }
                else
                {
                    output += "0 ";
                }
                current = temp;
            }
            
            output += "0";
        }
    
        output = output.TrimStart(' ');

        Console.WriteLine(output);
    }
}