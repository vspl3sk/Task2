﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
int first_num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int second_num = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (first_num < second_num){
    max = second_num;
}
else {
    max = first_num;
}
Console.WriteLine($"Большее из этих чисел {max}");