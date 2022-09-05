// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int start, int end)
{
    if (start < end)
    {
        if (start == end) return start;
        return start + SumNumbers(start + 1, end);
    }
    else
    {
        if (start == end) return start;
        return start + SumNumbers(start - 1, end);
    }
}

Console.Clear();
Console.WriteLine("Введите два числа, а я выведу на экран сумму всех натуральных элементов в промежутке этих чисел");
Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите первое число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(SumNumbers(m, n));