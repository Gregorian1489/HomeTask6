// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа через пробел");
string line = Console.ReadLine();
string [] array = line.Split(' ');
int [] arr = Array.ConvertAll(array, int.Parse);
int sum = 0;

for (int i = 0; i < arr.Length;i++)
{
    if (arr[i]<0)
    sum++;
}
Console.WriteLine($"Вы ввели {sum} отрицательных чисел");
    