Console.WriteLine("=============");
Console.WriteLine("Программа №52");
Console.WriteLine("=============");
Console.WriteLine();

int n = 4;
int [,] array = new int[n];
Random rand = new Random();
Console.WriteLine("======");
Console.WriteLine("Массив:");
for (int i = 0; i < array.Length ; i++) 
{
    for (int j = 0; j < n; j++)
    {
        array[i] = rand.Next(10, 100);
        Console.Write("| " + Convert.ToString(array[i]) + " | ");
    }
    Console.WriteLine();
}
Console.WriteLine("===========================");
for (int t = 0; t < array.Length; t++)
{
    int result = 0;
    for (int k = 0; k < n; k++)
    {
        result += array[t, k];
    }
    Console.WriteLine(result);
}
