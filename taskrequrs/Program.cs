﻿//Напишите программу для подсчета количества цифр в числе с помощью рекурсии.
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int res = 0;
                                // Я не знаю как, но это заработало)))))
int Req(int num1)               // Честно говоря, пока еще не совсем понял рекурсию,
{                               // поэтому, можно ли Вас попросить отметить
    if (num1== 0)               // недостатки этого кода и как их исправить?
    {                           // Спасибо!
        return 0;
    }
    res++;
    Req(num1/10);
    return res;
}
Req(num);
Console.Write(res);