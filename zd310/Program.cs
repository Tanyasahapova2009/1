﻿//принимает трехзначное и выдает второе число

Console.WriteLine("Введите трехзначное число ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a / 10;
int c = b % 10;
Console.WriteLine($"{c}");
