Console.WriteLine("=============\nПрограмма №56\n=============\n");

int [,] array = new int[4, 4];
Random rand = new Random();
Console.WriteLine("Массив:");
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = rand.Next(1, 10);
        Console.Write("| " + Convert.ToString(array[i,j]) + " | ");
    }
    Console.WriteLine();
}
Console.WriteLine("===========================");
int min = Int32.MaxValue;
int index = 0;
for (int i = 0; i < array.GetLength(0); i++) 
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    if (min > sum) 
    {
        min = sum;
        index ++;
    }
}
Console.WriteLine("Строка с наименьшей суммой = " + index + " Ее значение = " + min);
