﻿// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число , больше 1");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number < 2)// по условию на выходе от 1 до N , не стал добавлять вывод на 1 , решил что правильнее будет исключить
{
    Console.WriteLine("Число меньше или равно 1");
}
 Console.Write("Четные числа от 1 , до ");
 Console.WriteLine(Number);
 
for (int i = 2; i <= Number; i += 2)// переменная i  - для запуска цикла от 2 до Number
{
    Console.WriteLine(i);
}
