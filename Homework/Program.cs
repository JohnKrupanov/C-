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

// Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
int[] GenArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

int CountElem(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (Test(array[i]))
        {
            res++;
        }
    }
    return res;
}

bool Test(int n)
{
    return (n % 2 == 0);
}

int[] testArray = GenArray(4,100,999);

PrintArray(testArray);

int count = CountElem(testArray);

Console.WriteLine(count);
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
int[] GenArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArr(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

int SumPos (int [] array)
{
    int res = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        res += array[i];
    }
    return res;
}

int[] testArray = GenArray(4,1,30);
PrintArr(testArray);
int oddValueSum = SumPos(testArray);
Console.WriteLine(oddValueSum);
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

/*
double[] GenArray(int length, int minValue, int maxValue)
{
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

void PrintData(double res)
{
    Console.WriteLine(res);
}

double MaxMinSubtraction(double[] array)
{
    double max = double.MinValue;
    double min = double.MaxValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return max - min;
}

double[] testArray = GenArray(5, 1, 100);
PrintArray(testArray);
PrintData(MaxMinSubtraction(testArray));
*/

// Task 41
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
string ReadDataStr(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}

int CountPositivNumber(string str)
{
    int count = 0;
    
    string strWoSp = str.Replace(" ", "");

    string[] strArr = strWoSp.Split(",");
    
    int[] intArr = new int[strArr.Length];

    for (int i = 0; i < intArr.Length; i++) intArr[i] = int.Parse(strArr[i]);

    for (int i = 0; i < intArr.Length; i++) if (intArr[i] > 0) count++;

    return count;
}

string sequenceNumbers = ReadDataStr("Введите последовательность чисел через запятую: ");

int countPosNum = CountPositivNumber(sequenceNumbers);

Console.WriteLine("Количество положительных чисел равно: " + countPosNum);
*/

// Task 43
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
double ReadData(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToDouble(Console.ReadLine() ?? "0");
}

double xVolume(double b1, double k1, double b2, double k2)
{
    double xVol = (b2 - b1) / (k1 - k2);
        return xVol;
}


double yVolume(double b1, double k1, double x)
{
    double y = k1 * x + b1;
    return y;
}

double b1 = ReadData("Введите значение b1: ");
double k1 = ReadData("Введите значение k1: ");
double b2 = ReadData("Введите значение b2: ");
double k2 = ReadData("Введите значение k2: ");

double x = xVolume(b1, k1, b2, k2);
double y = yVolume(b1, k1, x);

Console.WriteLine("Значение Х = " + x);
Console.WriteLine("Значение Y = " + y);
*/


//  Task 47
//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/*
double[,] CreateRandom2dArray()
{
    Console.Write("Input a rows of array: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a columns of array: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int i = 0; int j = 0;

    double[,] array = new double[rows, columns];
    while (i < rows)
    {
        j = 0;
        while (j < columns)
        {
            array[i, j] = Math.Round(new Random().Next(-10, 11) + new Random().NextDouble(), 1);
            j++;
        }
        i++;
    }
    return array;
}

void Print2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[,] myArray = CreateRandom2dArray();
Print2dArray(myArray);
*/

// Task 50

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

/*
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Gen2DArrFibo(int column, int row)
{
    int[] arr1D = new int[column * row];
    arr1D[0] = 0;
    arr1D[1] = 1;
    for (int i = 2; i < arr1D.Length; i++)
    {
        arr1D[i] = arr1D[i - 1] + arr1D[i - 2];
    }
    int[,] arr2D = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr2D[i, j] = arr1D[i * column + j];
        }
    }
    return arr2D;
}

void SerchElemAndPrint(int[,] arr2D, int serchElem)
{
    bool elemSerch = false;
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            if (serchElem == arr2D[i, j])
            {
                elemSerch = true;
                Console.ForegroundColor = System.ConsoleColor.Red;
            }
            Console.Write(arr2D[i, j] + " \t");
            Console.ForegroundColor = System.ConsoleColor.White;
        }
        Console.WriteLine();
    }
    if (elemSerch == false)
    {
        Console.ForegroundColor = System.ConsoleColor.Red;
        Console.WriteLine("Элемент " + serchElem + " не найден");
    }
    Console.ForegroundColor = System.ConsoleColor.White;
}

int column = ReadData("Количество столбцов матрицы: ");
int row = ReadData("Количество строк матрицы: ");
int findeNum = ReadData("Введите искомое число ");

int[,] arr2DFibo = Gen2DArrFibo(column, row);

Console.WriteLine();
SerchElemAndPrint(arr2DFibo, findeNum);
*/

// Task 52
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Gen2DArrayInt(int row, int column)
{
    int i = 0; int j = 0;
    int[,] arr = new int[row, column];
    while (i < row)
    {
        j = 0;
        while (j < column)
        {
            arr[i, j] = new Random().Next(0, 101);
            j++;
        }
        i++;
    }
    return arr;
}

void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int[] MeanColum(int[,] arr)
{
    int[] means = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            means[i] = means[i] + arr[j, i];
        }
        means[i] = means[i] / arr.GetLength(0);
    }
    return means;
}

int DiagAverage(int[,] arr)
{
    int res = 0;
    int count = 0;
    int min = arr.GetLength(0) > arr.GetLength(1) ? arr.GetLength(1) : arr.GetLength(0);

    for (int i = 0; i < min; i = i + 1)
    {
        res = res + arr[i, i];
        count = count + 1;
    }
    res = res / count;
    return res;
}

int row = ReadData("Количество строк матрицы: ");
int column = ReadData("Количество столбцов матрицы: ");

int[,] arr2D = Gen2DArrayInt(row, column);

int[] average = MeanColum(arr2D);

Print2DArr(arr2D);

Console.WriteLine();
Console.WriteLine("Среднее арифметическое по столбцам: ");

Print1DArr(average);

int diagAver = DiagAverage(arr2D);
Console.WriteLine("Среднее арифметическое по диагонали: ");
Console.WriteLine(diagAver);
*/

// Task 54
// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a rows of array: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a columns of array: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void SortLine(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
}

void Print2dArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i,j]} ");
}
Console.WriteLine();
}
}

int[,] myArray = CreateRandom2dArray();
Print2dArray(myArray);

Console.WriteLine();
SortLine(myArray);
Print2dArray(myArray);
*/

// Task 56
// Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a rows of array: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a columns of array: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

int SumLine(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

void Print2dArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i,j]} ");
}
Console.WriteLine();
}
}

int[,] myArray = CreateRandom2dArray();
Print2dArray(myArray);

int minSumLine = 0;
int sumLine = SumLine(myArray, 0);
for (int i = 1; i < myArray.GetLength(0); i++)
{
    int tempSumLine = SumLine(myArray, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}
minSumLine = minSumLine + 1;

Console.WriteLine();
Print2dArray(myArray);

Console.WriteLine("Номер строки с наименьшей суммой: " + minSumLine);
Console.WriteLine("Наименьшая сумма равна: " + sumLine);
*/

// Task 58
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

/*
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Gen2DArrayInt(int row, int column, int range)
{
    int i = 0; int j = 0;
    int[,] arr = new int[row, column];
    while (i < row)
    {
        j = 0;
        while (j < column)
        {
            arr[i, j] = new Random().Next(0, range);
            j++;
        }
        i++;
    }
    return arr;
}

void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}

void Mylti2DArr(int[,] arr1, int[,] arr2, int[,] resArr)
{

    for (int i = 0; i < resArr.GetLength(0); i++)
    {
        for (int j = 0; j < resArr.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                sum += arr1[i, k] * arr2[k, j];
            }
            resArr[i, j] = sum;
        }
    }
}

Console.Clear();

Console.WriteLine("Для корректного решения задачи необходимо ввести данные.");
Console.WriteLine("Количество столбцов первой матрицы должно быть равно количеству строк второй");

int row1 = ReadData("Количество строк первой матрицы: ");
int colFirstRowSec = ReadData("Количество СТРОК первой и СТОЛБЦОВ второй матрицы: ");
int column2 = ReadData("Количество столбцов второй матрицы: ");
int range = ReadData("Диапазон элементов массива от 0 до ..... ? : ");
Console.WriteLine();

int[,] arr2DFirst = Gen2DArrayInt(row1, colFirstRowSec, range);

int[,] arr2DSecond = Gen2DArrayInt(colFirstRowSec, column2, range);

Console.WriteLine("Первый 2D массив: ");
Print2DArr(arr2DFirst);
Console.WriteLine();
Console.WriteLine("Второй 2D массив: ");
Print2DArr(arr2DSecond);

int[,] res2DArr = new int[row1, column2];
Mylti2DArr(arr2DFirst, arr2DSecond, res2DArr);

Console.WriteLine();
Console.WriteLine("произведение 2х матриц: ");
Print2DArr(res2DArr);
*/

// Task 60
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


/*int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void Print3DArr (int[,,] arr3D)
{
  for (int i = 0; i < arr3D.GetLength(0); i++)
  {
    for (int j = 0; j < arr3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < arr3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={arr3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void Gen3DArray(int[,,] arr3D)
{
  int[] temp = new int[arr3D.GetLength(0) * arr3D.GetLength(1) * arr3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < arr3D.GetLength(0); x++)
  {
    for (int y = 0; y < arr3D.GetLength(1); y++)
    {
      for (int z = 0; z < arr3D.GetLength(2); z++)
      {
        arr3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

Console.Clear();

Console.WriteLine("Введите размер 3D массива X-Y-Z");
int x = ReadData("Введите X: ");
int y = ReadData("Введите Y: ");
int z = ReadData("Введите Z: ");
Console.WriteLine();

int[,,] array3D = new int[x, y, z];

Gen3DArray(array3D);

Print3DArr(array3D);
*/

// Task 62
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int len = 4;
int[,] table = new int[len, len];
FillArraySpiral(table, len);
PrintArray(table);

void FillArraySpiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}