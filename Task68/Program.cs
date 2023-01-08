Console.WriteLine("=============\nПрограмма №68\n=============\n");

int M = InputInt("Введите число M - ");
int N = InputInt("Введите число N - ");

Console.WriteLine($"A({M}, {N}) = {Akkerman(M, N)}");

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
