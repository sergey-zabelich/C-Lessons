﻿Console.Clear();
Console.WriteLine("Введите № задания которое хотите проверить: (№1, №2, №3, №4)");
string lesson = Console.ReadLine();

if (lesson == "1")
{
    //Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
    Console.Clear();                                // Очистка терминала от содержимого
    Console.WriteLine("Задание №1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
    Console.Write("Введите первое число: ");        // Ввод приглашения на экран
    int a = int.Parse(Console.ReadLine());          // Использование метода int.Parse для преобразования строки в число
    Console.Write("Введите второе число: ");        // Ввод приглашения на экран
    int b = int.Parse(Console.ReadLine());          // Использование метода int.Parse для преобразования строки в число

    int max = a;
    int min = a;


    if (b > max) max = b;                          // Вычисление максимального числа
    if (b < min) min = b;                          // Вычисление минимального числа

    Console.Write("max = ");                       // Вывод результата
    Console.WriteLine(max);

    Console.Write("min = ");                       // Вывод результата
    Console.WriteLine(min);
}

else if (lesson == "2")
{
    // Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    Console.Clear();                                // Очистка терминала от содержимого
    Console.WriteLine("Задание №2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
    Console.Write("Введите первое число: ");        // Ввод приглашения на экран
    int a1 = int.Parse(Console.ReadLine());         // Использование метода int.Parse для преобразования строки в число
    Console.Write("Введите второе число: ");        // Ввод приглашения на экран
    int b1 = int.Parse(Console.ReadLine());         // Использование метода int.Parse для преобразования строки в число
    Console.Write("Введите третье число: ");        // Ввод приглашения на экран
    int c1 = int.Parse(Console.ReadLine());         // Использование метода int.Parse для преобразования строки в число
    int max = a1;
    if (a1 > max) max = a1;
    if (b1 > max) max = b1;
    if (c1 > max) max = c1;
    Console.Write("Максимальное из введённых чисел = ");
    Console.WriteLine(max);
}

else if (lesson == "3")
{
    //Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
    Console.Clear();
    Console.WriteLine("Задание №3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
    Console.Write("Введите число для проверки на чётность: ");        // Ввод приглашения на экран
    int number = int.Parse(Console.ReadLine());                       // Использование метода int.Parse для преобразования строки в число
    if ((number % 2) == 0)
    {
        Console.Write("Это число является чётным");
    }
    else
    {
        Console.Write("Это число не является чётным");
    }

}

else if (lesson == "4")
{
    //Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
    Console.Clear();
    Console.WriteLine("Задание №4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
    Console.Write("Введите число: ");                                  // Ввод приглашения на экран
    int numbers = int.Parse(Console.ReadLine());                       // Использование метода int.Parse для преобразования строки в число
    Console.WriteLine("Чётные числа от 1 до {0}:", numbers);
    int first_step = 1;
    while (first_step <= numbers)
    {
        if (first_step % 2 == 0)
        {
            Console.Write(first_step + " ");
        }
        first_step++;
    }
    Console.WriteLine();
}
else 
{
    Console.WriteLine("Такого задания нет, попробуйте еще раз! ");
}