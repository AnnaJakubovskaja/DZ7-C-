﻿/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/



Console.WriteLine("Введите размеры массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,10));  
}

Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j]+ "\t  ");
        Console.WriteLine();
}

Console.WriteLine("Введите координаты искомого числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
    if (a>(m) && b>(n))
    Console.WriteLine("Tакого числа нет. Введенные координаты вне границ массива. Повторите ввод параметров.");
    else if (a>(m))
    Console.WriteLine("Tакого числа нет. Введенные координаты вне границ массива. Повторите ввод параметров.");
    else if (b>(n))
    Console.WriteLine("Tакого числа нет. Введенные координаты вне границ массива. Повторите ввод параметров.");
    else
    {
        object c = array.GetValue(a,b);
        Console.WriteLine ($"Искомое число : {c}");
    }
