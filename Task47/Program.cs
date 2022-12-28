Console.WriteLine("=============");
Console.WriteLine("Программа №47");
Console.WriteLine("=============");
Console.WriteLine();

Console.WriteLine("Введите два числа");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double [] array = new double[m * n];
Random rand = new Random();
Console.WriteLine("======");
Console.WriteLine("Массив:");
for (int i = 0; i < array.Length ; i++) 
{
    array[i] = rand.Next(0, 100) + rand.NextDouble();
    Console.Write("| " + Convert.ToString(Math.Round(array[i], 2)) + " | ");
}
