// Задача: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int min = 2;

if (number >= min)
{
    while (min < number)
    {
        Console.Write($"{min} ");
        min = min + 2;
    }
}
else
{
    Console.Write($"Четных чисел от 1 до {number} нет, поскольку {number} меньше 1.");
}