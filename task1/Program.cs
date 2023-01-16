// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int first_num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int second_num = Convert.ToInt32(Console.ReadLine());

if (first_num > second_num)
Console.WriteLine($"{second_num} меньше, чем {first_num}");
else
{
    Console.WriteLine($"{first_num} меньше, чем {second_num}");
}