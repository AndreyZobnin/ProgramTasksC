﻿Console.Write("Введи трёхзначное число: "); // Выыодим приглашение
int TDN = Convert.ToInt32(Console.ReadLine()); // задаем переменную TDN и Преобразуем заданное значение в 32-битовое целое число
string NumberSTR = Convert.ToString(TDN); //переменная строковая NumberSTR преобразования любых типов данных к их строковому представлению
Console.WriteLine("вторая цифра этого числа -> "+NumberSTR[1]); // в параметре +NumberSTR[] выбираем кукую цифру будет выдавать через [X]