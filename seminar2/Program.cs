// Seminar 2

//Theory

/*

13254 / 10 = 1325
13254 / 100 = 132
13254 / 1000 = 13
13254 / 10000 = 1

13254 % 10 = 4
13254 % 100 = 54
13254 % 1000 = 254
13254 % 10000 = 3254
24365 / 100 % 100 = 43
 */

// Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.

/*
int CutNumber(int num) 
{
    int hundreds = num / 100;
    int units = num % 10;

    return hundreds * 10 + units;
    }

int randNumber = new Random().Next(100, 1000);

int newNumber = CutNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {newNumber}");
*/

//Task 2. Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно a и b.

/*
bool isDividable(int num, int div1, int div2)
{
// if(num % div1 == 0 && run % div2 ==0)
//     return true;
// else 
//    return false;


return num % div1 == 0 && num % div2 ==0;
}

Console.WriteLine("Input a number for cheking: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a firsr divider: ");
int divider1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second divider: ");
int divider2 = Convert.ToInt32(Console.ReadLine());

bool res = isDividable(number, divider1, divider2);
Console.WriteLine(res); // вывод результата "True" или "False"

// if(res) Console.WriteLine("Yes");
// else Console.WriteLine("No");
// Более визуальный вывод результата.
*/


//Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

/*
int MaxNum(int randNumber)
{
    int num1 = randNumber / 10;
    int num2 = randNumber % 10;
    if(num1 > num2) return num1;
    else return num2;
}
int randNumber = new Random().Next(10, 100);
Console.WriteLine(randNumber);
int res = MaxNum(randNumber);
Console.WriteLine(res);
*/

//Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

bool SquerCheck(int num1, int num2)
{
    return (num1 == num2 * num2 || num2 == num1 * num1);
}
// int num1 = new Random().Next(1, 10);
// Console.WriteLine(num1);
// int num2 = new Random().Next(10, 100);
// Console.WriteLine(num2);
Console.WriteLine("Input a firsr divider: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second divider: ");
int num2 = Convert.ToInt32(Console.ReadLine());
bool res = SquerCheck(num1, num2);
Console.WriteLine(res);
