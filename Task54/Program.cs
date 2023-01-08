Console.WriteLine("=============\nПрограмма №54\n=============\n");

int [,] array = new int[3, 4];
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
// int index = 0;
// int max = array[index, 0];
for (int i = 0; i < array.GetLength(0); i++) 
{
    int max = Int32.MaxValue;
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < array.GetLength(1) - 1; z++)
        {
             if (array[i, z] < array[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
            {
                int temp = 0;
                temp = array[i, z];
                array[i, z] = array[i, z + 1];
                array[i, z + 1] = temp;
            }
        }
    }
}
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write("| " + Convert.ToString(array[i,j]) + " | ");
    }
    Console.WriteLine();
}