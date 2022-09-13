// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// System.Console.WriteLine("Ввдедите количество строк: ");
// int str = int.Parse(Console.ReadLine());

// System.Console.WriteLine("Ввдедите количество столбцов: ");
// int col = int.Parse(Console.ReadLine());


// double[,] matrix = new double[str , col];

// void NewRandomMatrix (double[,] matrix)
// {
//     Random rand = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] =rand.NextDouble() * 30 - 10;
//             Console.Write("{0,8:F2}", matrix[i, j]);
//         }
//         Console.WriteLine();
//     }
// }

// NewRandomMatrix(matrix);






// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// int GetDigitCondition(string message)
// {
//     Console.WriteLine(message);
//     int colum = int.Parse(Console.ReadLine()!);
//     while (colum < 0)
//     {
//         Console.Write("Некорректная цифра введите новое число: ");
//         int temp = int.Parse(Console.ReadLine()!);
//         colum = temp;
//     }
//     return colum;
// }

// int GetDigit(string message)
// {
//     Console.WriteLine(message);
//     int start = int.Parse(Console.ReadLine()!);
//     return start;
// }
// double [,] CreateMultiDouble(int minNum, int maxNum)
// {
//     double [,] multi = new double[10 ,10];
//     for (int i = 0; i < multi.GetLength(0); i++)
//     {
//         for (int j = 0; j < multi.GetLength(1); j++)
//         {
//             Random digit = new Random();
//             multi[i,j] = digit.NextDouble()*(maxNum - minNum) + minNum;
//         }
//     }
//     return multi;
// }

// void PrintMultiDouble (double [,] multi)
// {
//     for (int i = 0; i < multi.GetLength(0); i++)
//     {
//         for (int j = 0; j < multi.GetLength(1); j++)
//         {
//             if(multi[i,j] == Math.Round(multi[i,j]))
//             {
//                 Console.Write($"{multi[i, j]}\t ");
//             }
//             else
//             {
//                 Console.Write($"{multi[i, j]:F2}\t ");
//             }
//         }
//         Console.WriteLine();
//     }
// }

// void FindValue (double [,] multi , int row , int colum)
// {
//     try
//     {
//         Console.WriteLine($"ячейка [{row}], [{colum}] содержит значение: {multi[row,colum]}");
//     }
//     catch 
//     {
//         Console.Write("в массиве нет такой позиции");   
//     }
// }

// double[,] matrix = CreateMultiDouble(GetDigit("Ввод числавого диопазона  : "), GetDigit("Ввод числового окончания" ));
// PrintMultiDouble(matrix);
// FindValue(matrix, GetDigitCondition("Введите значение строки для поиска в массиве") , GetDigitCondition("Введите значение столбца для поиска в массиве"));



// 17 -> такого числа в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void NewRandomMatrix (int[,] matr)
{
    System.Console.WriteLine();
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(1, 15);
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
    System.Console.WriteLine();
}    

int GetMidMath (int[,] matr)
{
    int column = 0;
    int sum = 0;
    double midMath = 0;
    while (column < matr.GetLength(1))
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i, column];
        }
        midMath = (double) sum / matr.GetLength(0);
        System.Console.WriteLine($"The {column +1} column arifmetic mean = {midMath.ToString("F1")}");
        column += 1;
        sum = 0;
    }   return sum;
}
int[,] matrix = new int[9, 5];

NewRandomMatrix(matrix);
GetMidMath(matrix);