Console.WriteLine("Задать массив или создать рандомный?");
string input = Console.ReadLine();

if (input == "задать")
{
    Console.WriteLine("Задайте массив");
    string inp = Convert.ToString(Console.ReadLine());
    string[] array = inp.Split(new char[]{' ', ','}, StringSplitOptions.RemoveEmptyEntries);
    int[] arr = array.Select(Int32.Parse).ToArray();
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int result = arr[i] % 2;
        if (result == 0) amount++;
    }
    Console.WriteLine($"В данном массиве {amount} четных чисел");
}
else if (input == "создать")
{
    Random rand = new Random();
    int count = rand.Next(2, 10);
    int[] arr = new int[count];
    for (int i = 0; i < arr.Length; i++)
        arr[i] = rand.Next(100, 999);
        Console.WriteLine("======= Массив =======");
        for (int i = 0; i < count; i++)
        {
            Console.Write(arr[i] + " "); 
            
        }
        Console.WriteLine();
        Console.WriteLine("======================");
        int amount = 0;
        for (int i = 0; i < count; i++)
        {
            int result = arr[i] % 2;
            if (result == 0) amount++;
        }
        Console.WriteLine($"В данном массиве {amount} четных чисел");
}



