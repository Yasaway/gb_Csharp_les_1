// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введите 3 числа");
Console.Write("1 число: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2 число: ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("3 число: ");
int a3 = Convert.ToInt32(Console.ReadLine());
if (a1 > a2 & a1 > a3)
{
    Console.WriteLine("Число " + a1 + " больше!");
}
else
{
    if (a2 > a1 & a2 > a3)
    {
        Console.WriteLine("Число " + a2 + " больше!");
    }
    else
    {
        Console.WriteLine("Число " + a3 + " больше!");
    }
}
