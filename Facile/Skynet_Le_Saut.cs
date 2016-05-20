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
class Player
{
    static int road;
    static int gap;
    static int platform;
    
    static void Main(string[] args)
    {
        road = int.Parse(Console.ReadLine()); // the length of the road before the gap.
        gap = int.Parse(Console.ReadLine()); // the length of the gap.
        platform = int.Parse(Console.ReadLine()); // the length of the landing platform.
        bool jump = false;
        
        // game loop
        while (true)
        {
            int speed = int.Parse(Console.ReadLine()); // the motorbike's speed.
            int coordX = int.Parse(Console.ReadLine()); // the position on the road of the motorbike.

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            string cmd;
            
            if (jump)
            {
                cmd = "SLOW";
            }
            else
            {
                Calc(speed, coordX, out cmd);
            }
            
            if (cmd == "JUMP")
            {
                jump = true;
            }
            
            Console.WriteLine(cmd); // A single line containing one of 4 keywords: SPEED, SLOW, JUMP, WAIT.
        }
    }
    
    static bool Calc(int speed, int position, out string cmd)
    {
        bool result = true;
        cmd = "";
        
        if (position >= road)
        {
            cmd = "";
            result = false;
        }
        else if (position + speed >= road + gap && position + speed < road + gap + platform)
        {
            cmd = "JUMP";
            result = CanStop(speed, road + gap + platform - position - speed - 1);
            
            if(!result)
            {
                cmd = "";
                result = true;
            }
        }
        
        if (result && cmd == "")
        {
            if (Calc(speed + 1, position + speed + 1, out cmd))
            {
                cmd = "SPEED";
                result = true;
            }
            else if (Calc(speed , position + speed, out cmd))
            {
                cmd = "WAIT";
                result = true;
            }
            else if (Calc(speed - 1 , position + speed - 1, out cmd))
            {
                cmd = "SLOW";
                result = true;
            }
            else
            {
                cmd = "";
                result = false;
            }
        }
        
        if(result)
        {
            Console.Error.WriteLine("road : " + road + " | gap : " + gap + " | platform : " + platform + " | speed : " + speed + " | position : " + position );
        }
        return result;
    }
    
    static bool CanStop(int speed, int distance)
    {
        bool result;
        if (distance < 0)
        {
            result = false;
        }
        else if (speed == 0)
        {
            if (distance >= 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
        }
        else
        {
            result = CanStop(speed - 1, distance - (speed - 1));
        }
        
        Console.Error.WriteLine("can stop | speed : " + speed + " | distance : " + distance + " | result : " + result);
        return result;
    }
}