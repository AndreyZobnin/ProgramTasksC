﻿int number = new Random().Next(1, 1000000); //генератор случайных чисел от 1 до 200
int a = 7; // переменная а = 7
int b = 23; 
string Result = " "; //строковая переменная result
if (number % a == 0 && number % b == 0) Result = "кратно обоим числам"; // проверяем если при деление на число из random переменная a и переменная b равна 0
else if (number % a != 0 && number % b != 0) Result = "не кратно ни одному из чисел"; //если не равно
System.Console.WriteLine();
System.Console.WriteLine($"Число кратное {number} {Result} "); //печатаем на экран
