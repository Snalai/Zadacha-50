// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// Я случайно сделал поиск на то, есть ли определенное число или нет.
Console.WriteLine("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Какое число желаете найти?");
int x = Convert.ToInt32(Console.ReadLine());
int s = 0;
int[,] num = new int[m, n];
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        num[i, j] = new Random().Next(-99, 100);
        Console.Write($" {num[i, j]}");
        if (num[i, j] == x)
        {
            s++;
        }
    }
    Console.WriteLine();
}
if (s > 0)
{
    Console.WriteLine($"{x} есть в массиве");
}
if (s == 0)
{
    Console.WriteLine($"{x} нет в массиве");
}
//Здесь я сделал поиск введенного человеком числа. 
// Console.WriteLine("Введите колличество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите колличество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите строку: ");
// int m1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите столбец: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// int answ = 0;
// int score = 0;
// int[,] num = new int[m, n];
// for (int i = 0; i < num.GetLength(0); i++)
// {
//     for (int j = 0; j < num.GetLength(1); j++)
//     {
//         num[i, j] = new Random().Next(-99, 100);
//         Console.Write($" {num[i, j]}");
//         if (i == (m1 - 1) && j == (n1 - 1))
//         {
//             answ = num[i, j];
//             score++;
//         }
//     }
//     Console.WriteLine();
// }
// if (score > 0)
// {
//     Console.WriteLine($"{answ}");
// }
// if (score == 0)
// {
//     Console.WriteLine($"Такого элемента нет");
// }
