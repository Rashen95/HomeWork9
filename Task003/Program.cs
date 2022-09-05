// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29 - !!!В примере ошибка. Согласно таблице число 29 будет выдавать если m = 3, n = 2!!!

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.Clear();
Console.WriteLine("Введите неотрицательные числа m и n, а я вычислю функцию Аккермана");
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(Akkerman(m, n));