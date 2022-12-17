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
        int result = 0;
        for (int i = 0; i < count; i++)
        {
            if (i % 2 != 0) result = arr[i] + result;
        }
        Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {result}");