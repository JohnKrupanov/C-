// Task 1. 
//Напишите программу, которая принимает на 
//вход число (А) и выдаёт сумму чисел от 1 до А.

/*
int sum (int a)
{
    int result = 0;
    for(int i = 1; i <= a; i++)
        result += i;
    return result;
}
Console.WriteLine("in put the number");

int nunumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sum(nunumber));
*/

// Task 2.
// Напишите программу, которая принимает на
// вход число и выдаёт количество цифр в числе.

/*
int CountNumbers(int N)
{
    int count = 1;
    for(; 10 <= N; count++)
        N = N/10;
    return count; 
}
Console.WriteLine("input the number");
int nunumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CountNumbers(nunumber));
*/

// Task 3.
//Напишите программу, которая принимает на вход 
// число N и выдаёт произведение нечетных чисел от 1 до N.

/*
int prov (int a)
{
    int result = 1;
    for(int i = 1; i <= a; i= i+2)
        result *= i;
    return result;
}
Console.WriteLine("in put the number");

int nunumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(prov(nunumber));
*/

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

// int[] myArray = CreateRandomArray(length, min, max);
// WriteArray(myArray);