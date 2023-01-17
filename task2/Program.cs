// Задача: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int first_num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int second_num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int third_num = Convert.ToInt32(Console.ReadLine());

if (first_num > second_num)
{
    if (first_num > third_num)
    {
        Console.WriteLine($"Максимальное число - {first_num}");
    }
        else
    {
        Console.WriteLine($"Максимальное число - {third_num}");
    }
}
else
{
    if (second_num > third_num)
    {
        Console.WriteLine($"Максимальное число - {second_num}");
    }
    else
    {
        Console.WriteLine($"Максимальное число - {third_num}");
    }
}