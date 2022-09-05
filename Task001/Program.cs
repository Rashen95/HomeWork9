// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

void RowOfNumbers(int start, int end)
{
    if (start < end)
    {
        if (start == end)
        {
            Console.Write(start);
            return;
        }
        Console.Write($"{start}, ");
        RowOfNumbers(start + 1, end);
    }
    if (start >= end)
    {
        if (start == end)
        {
            Console.Write(start);
            return;
        }
        Console.Write($"{start}, ");
        RowOfNumbers(start - 1, end);
    }
}

Console.Clear();
Console.WriteLine("Введите два числа, а я выведу все числа от первого до второго включительно");
Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите первое число: ");
int n = int.Parse(Console.ReadLine());
RowOfNumbers(m, n);