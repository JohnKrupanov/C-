// Задача 2: Напишите программу, которая на вход принимает два числа и выдает,
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
