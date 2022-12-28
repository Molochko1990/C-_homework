Console.WriteLine("=============");
Console.WriteLine("Программа №50");
Console.WriteLine("=============");
Console.WriteLine(); 

int [] array = {2, 5, 9, 21, 66}; 
Console.WriteLine("Введите индекс элемента в массиве");
int i = Convert.ToInt32(Console.ReadLine());
try
{
    if (Convert.ToBoolean(array[i])) Console.WriteLine(array[i]);
}
catch (System.IndexOutOfRangeException)
{
    Console.WriteLine("Такого элемента нет");
}

