﻿/*
int intNumber = 25;
double doubleNumber = 12.12;
string text = "some text";
bool logicVar = trug; 
*/

/*
int num1 = 5;
int num2 = 10;
Console.WriteLine("мой номер " + num1 + " and " + num2 + " and it is good!");
Console.WriteLine($"мой номер {num1} and {num2} and it is good!");
*/

/*
Console.Write("input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your number is " + num);
*/

// Task 1. Напишите программу которая на вход принимает два числа и проверяет, 
//является ли первое число квадратом второго. 

Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if(num1 == quad2)
{
    Console.WriteLine("Yes!");
}
else
{
    Console.WriteLine("No!");
}