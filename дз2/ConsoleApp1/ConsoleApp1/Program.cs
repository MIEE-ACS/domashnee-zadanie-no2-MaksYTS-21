﻿//Вариант 13 Радзивиловский УТС-21
using System;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите R:");
            double R = double.Parse(Console.ReadLine());
            double y;
            for (double X = -5; X < 70; X += 0.2)
            {
                if (X >= -5 && X <= -3)
                {
                    y = X + 3;
                    Console.Write($"y:{y:0.00}\n");
                }
                else
                if (X >= -3 && X <= 0)
                {
                    y = Math.Sqrt(R * R - X * X);
                    Console.Write($"y:{y:0.00}\n");
                }
                else
                if (X >= 0 && X <= 6)
                {
                    y = (6 - X) / 2;
                    Console.Write($"y:{y:0.00}\n");
                }
                else
                if (X >= 6 && X <= 9)
                {
                    y = X - 6;
                    Console.Write($"y:{y:0.00}\n");
                }
            }
        }
    }
}
