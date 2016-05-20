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
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine();
        
        Dictionary<string, string[]> dico = new Dictionary<string, string[]>
        {
            {"A", new string[H]}, 
            {"B", new string[H]},
            {"C", new string[H]},
            {"D", new string[H]},
            {"E", new string[H]},
            {"F", new string[H]},
            {"G", new string[H]},
            {"H", new string[H]},
            {"I", new string[H]},
            {"J", new string[H]},
            {"K", new string[H]},
            {"L", new string[H]},
            {"M", new string[H]},
            {"N", new string[H]},
            {"O", new string[H]},
            {"P", new string[H]},
            {"Q", new string[H]},
            {"R", new string[H]},
            {"S", new string[H]},
            {"T", new string[H]},
            {"U", new string[H]},
            {"V", new string[H]},
            {"W", new string[H]},
            {"X", new string[H]},
            {"Y", new string[H]},
            {"Z", new string[H]},
            {"?", new string[H]}
        };
        
        Dictionary<int, string> indexDico = new Dictionary<int, string>
        {
            {1,"A"}, {2,"B"}, {3,"C"}, {4,"D"}, {5,"E"}, {6,"F"}, {7,"G"}, {8,"H"}, {9,"I"}, {10,"J"}, {11,"K"}, {12,"L"}, {13,"M"}, {14,"N"},
            {15,"O"}, {16,"P"}, {17,"Q"}, {18,"R"}, {19,"S"}, {20,"T"}, {21,"U"}, {22,"V"}, {23,"W"}, {24,"X"}, {25,"Y"}, {26,"Z"}, {27,"?"}
        };
        
        for (int i = 0; i < H; i++)
        {
            string ROW = Console.ReadLine();
            for(int j=1; j <= 27; j++)
            {
                string letter = indexDico[j];
                dico[letter][i] = ROW.Substring((j-1)*L,L);
            }
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        for(int i = 0; i < H; i ++)
        {
            string line = "";
            for(int j = 0; j< T.Length; j++)
            {
                string letter = T.Substring(j,1).ToUpper();
                if (dico.ContainsKey(letter))
                {
                    line += dico[letter][i];
                }
                else
                {
                    line += dico["?"][i];
                }
            }
            
            Console.WriteLine(line);
        }
    }
}