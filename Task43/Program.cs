Console.WriteLine("=============");
Console.WriteLine("Программа №43");
Console.WriteLine("=============");
Console.WriteLine();
// Input data
Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
// Programm
double x = (b1 - b2)/(k2 - k1);
double y = (k2 * b1 - k1 * b2)/(k2 - k1);
if (k1 == k2) Console.WriteLine("Прямые не пересекаются");
else Console.WriteLine($"Прямые пересекаются в ({x};{y})");
