﻿Console.Clear();
Console.WriteLine("Enter b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter k2");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
double y = (b1*k2 - b2*k1) / (k2 - k1);
Console.WriteLine($"x = {x}; y = {y}");