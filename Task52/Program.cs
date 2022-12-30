Console.WriteLine("=============");
Console.WriteLine("Программа №52");
Console.WriteLine("=============");
Console.WriteLine();

int n = 4;
int [,] array = new int[n, n];
Random rand = new Random();
Console.WriteLine("======");
Console.WriteLine("Массив:");
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = rand.Next(10, 100);
        Console.Write("| " + Convert.ToString(array[i,j]) + " | ");
    }
    Console.WriteLine();
}
Console.WriteLine("===========================");
for (int i = 0; i < array.GetLength(0); i++)
{
    int result = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        result += array[j, i];
    }
    Console.WriteLine(result);
}
