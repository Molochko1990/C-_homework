Console.WriteLine("Программа №41");
Console.WriteLine("=============");
Console.WriteLine();
Console.WriteLine("Введите несколько чисел");
string inp = Convert.ToString(Console.ReadLine());
string[] array = inp.Split(new char[]{' ', ','}, StringSplitOptions.RemoveEmptyEntries);
int[] arr = array.Select(Int32.Parse).ToArray();
int amount = 0;
for (int i = 0; i < array.Length; i++)
{
    if (arr[i] > 0) amount++;
}
Console.WriteLine(amount);