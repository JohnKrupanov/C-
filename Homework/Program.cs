﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдает,
// какое число больше, а какое меньше.

/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num2 < num1)
{
    Console.Write("Min" + num2);
    Console.Write(" Max" + num1);
}
else
{
    Console.Write("Min" + num1);
    Console.Write(" Max" + num2);
}
*/

// Задача 4. Напишиите программу, которая принимает на вход три числа и выдает
// максимальное этих чисел.

/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num2 > max) max = num2;
if(num3 > max) max = num3;

Console.WriteLine(max);
*/

//Задача 6. Напишиите программу, которая на вход принимает число и выдает, 
// является ли число четным (делится ли оно на два без остатка).


/*Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.WriteLine("Да!");
}
else
{
    Console.WriteLine("Нет!");
}
*/

// Задача 8. Напишиите программу, которая на вход приниимает число (N),
// а ны выходе показывает все четные числа от 1 до N.

/*
Console.Write("Input a first number: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 0;

while(count <= num)
{
 if(count % 2 == 0)Console.Write(count + " ");
   count++;
}
*/

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

/*
int CutNumber(int num) 
{
    int hundreds = num / 10;
    int tenth = hundreds % 10;

    return tenth;
    }

int randNumber = new Random().Next(100, 1000);

int newNumber = CutNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {newNumber}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// ( или -1, если третьей цифры нет).

/*
int CutNumber(int num) 
{
    int hundreds = num / 100;
    int units = num % 10;
    if(hundreds >= 1) return units;
    else return (num - (num + 1));  
}

int randNumber = new Random().Next(10, 1000);

int newNumber = CutNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {newNumber}");
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

/*
bool week(int number)
{
    if(number == 6) 
    return true;
    else
    if(number == 7)
    return true;
    else
    return false;
}
Console.WriteLine("enter a number from 1 to 7: ");
int number = Convert.ToInt32(Console.ReadLine());
bool res = week(number);
Console.WriteLine(res);
*/

// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

/*
Console.Write("Enter a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

if((number / 10000) > 0 && (number / 10000) < 10)
{
    int num = number;
    bool PaliTest(int num)
    {
    bool res = false;
    int d1 = num / 10000;
    int d2 = (num / 1000) % 10;
    int d3 = (num / 10) % 10;
    int d4 = num % 10;
    res = ((d1 == d4) && (d2 == d3)) ? true : false;
    return res;    
    }
    bool res = PaliTest(num);
    Console.WriteLine(res);
    }
else
{
    Console.WriteLine("enter a five-digit number correctly");
    }
*/

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

/*
double Distance(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double res = 0;
    res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)+ Math.Pow(z1 - z2, 2));
    return res;
}
Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
double lenght = Distance(x1,x2,y1,y2,z1,z2);
Console.Write("Расстояние между точками равно: ");
Console.WriteLine(Distance (x1, x2, y1, y2, z1, z2));
*/


// Задача 23
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

/*
void cube(int n)
{
    if (n <= 0) Console.WriteLine("Uncorrected number");
    else
    {
        int count = 1;
        while (count <= n)
        {
            Console.WriteLine($"{count} - {Math.Pow(count,3)}");
            count++;
        }
    }
}

Console.Write("input number: ");
int num = Convert.ToInt32(Console.ReadLine());

cube(num);
*/


// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

/*
Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int degree = a;

for (int i = 1; i < b; i++)
{
degree = degree * a;
}
Console.WriteLine("A в степени B равно: " + degree);
*/

// Задача 27: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int SummaNumDigRemOfDiv(int num)
{
    int res = 0;
    while (num >0)
    {
        res = res + num%10;
        num = num /10;
    }
    return res;
}
Console.WriteLine("Введите любое натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SummaNumDigRemOfDiv(num));
*/

// Задача 29: 
// Напишите программу, которая задаёт массив из m элементов и 
// выводит их на экран.

/*
int lenArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,34);
    Console.Write(randomArray[i] + " ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/
