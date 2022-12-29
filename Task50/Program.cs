Console.WriteLine("=============");
Console.WriteLine("Программа №50");
Console.WriteLine("=============");
Console.WriteLine(); 

int [,] array = {{2, 5, 9}, {3, 4, 7}}; 
Console.WriteLine("Введите индекс элемента в массиве");
int i = Convert.ToInt32(Console.ReadLine());
int j = Convert.ToInt32(Console.ReadLine());
try
{
    if (Convert.ToBoolean(array[i, j])) Console.WriteLine(array[i, j]);
}
catch (System.IndexOutOfRangeException)
{
    Console.WriteLine("Такого элемента нет");
}

