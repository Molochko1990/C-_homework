Console.WriteLine("=============\nПрограмма №64\n=============\n");

int M = InputInt("Введите число M - ");
int N = InputInt("Введите число N - ");

Console.WriteLine($"Сумма элементов от {M} до {N} = {NumSum(M, N)}");

int NumSum(int M, int N)
{
    if (M == N) return N;
    return N + NumSum(M, N - 1);
}



int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
