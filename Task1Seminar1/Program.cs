﻿//1 дз

int a, b; //воодим 2 переменные
Console.WriteLine("Введите первое число : ");
a = Convert.ToInt32(Console.ReadLine()); //получаем первое число от ользователя
Console.WriteLine("Введите второе число : ");
b = Convert.ToInt32(Console.ReadLine()); //получаем второе число от ользователя
if (a > b) //Сравниваем первое число и второе
   {
      Console.WriteLine("Наибольшее число : {0}", a); // выводим на экран первое число если оно больше 2го
   }
else //Иначе
   {
      Console.WriteLine("Наибольшее число: {0} ", b); // Выводим второе число на экран консоли
   }
