Random rand = new Random();
int count = rand.Next(4, 10);
double[] arr = new double[count];
for (int i = 0; i < arr.Length ; i++) 
{
    arr[i] = rand.Next(0, 100) + rand.NextDouble();
    Console.WriteLine(Convert.ToString(Math.Round(arr[i], 2)));
}
Console.WriteLine("=====");
// min and max el
double minElement = arr[0];
double maxElement = arr[0];
 for (int i = 0; i < arr.Length ; i++) 
 {
    if (minElement > arr[i]) minElement = arr[i];
    else if (maxElement < arr[i]) maxElement = arr[i];
 }
Console.WriteLine("Минимальный элемент массива = " + Math.Round(minElement, 2));
Console.WriteLine("Максимальный элемент массива = " + Math.Round(maxElement, 2));
Console.WriteLine("=====");
// разница между элементами
Console.WriteLine("Разница между элементами = " + (maxElement - minElement));
