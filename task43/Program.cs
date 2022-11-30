// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Даны уравнения:");
Console.WriteLine("y = k1 * x + b1");
Console.WriteLine("y = k2 * x + b2");
Console.WriteLine("Введите b1 k1 b2 k2 через пробел");

string line = Console.ReadLine();
string [] array = line.Split(' ');
double [] arr = Array.ConvertAll(array, double.Parse);

if (arr[1] == arr[3]) Console.WriteLine("Прямые параллельны");
else
{
    double x = ((arr[2]-arr[0] )/(arr[1]-arr[3]));
    double y = arr[1]*x + arr[0];
    Console.WriteLine($"Координаты точки пересечения: {Math.Round(x,2)} {Math.Round(y,2)}");
}
