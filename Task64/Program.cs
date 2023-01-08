Console.WriteLine("=============\nПрограмма №64\n=============\n");
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int Factorial(int N)
{
    if (N == 1) return N; 
    else Console.Write($"{N} "); 
    return Factorial(N - 1);
}
Console.WriteLine(Factorial(N));