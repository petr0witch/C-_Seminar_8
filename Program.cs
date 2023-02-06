// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/*
int[,] Create2dArr()
{
    // Console.WriteLine("Задайте двухмерный массив.");
    // Console.Write("Укажите кол-во строк: ");
    // int rows = Convert.ToInt16(Console.ReadLine());
    // Console.Write("Укажите кол-во столбов: ");
    // int cols = Convert.ToInt16(Console.ReadLine());

    int[,] array = new int[4, 4];

    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);
    return array;
} 

void Show2DArr(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] RowsSort(int[,] array)
{   
    
    for(int i = 0; i < array.GetLength(0); i++)
    {   
        for(int j = 0; j <array.GetLength(1); j++)
        {
            for(int max = 0; max < array.GetLength(0); max++)
            {
                int maxValue = array[i, max];
                if(maxValue < array[i, j]) 
                {
                    int temp = array[i, max];
                    array[i, max] = array[i, j]; 
                    array[i, j] = temp; 
                }
            }
        }
    }
    return array;
}

int[,] array = Create2dArr();
Show2DArr(array);
Show2DArr(RowsSort(array));
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*
int[,] Create2dArr()
{
    // Console.WriteLine("Задайте двухмерный массив.");
    // Console.Write("Укажите кол-во строк: ");
    // int rows = Convert.ToInt16(Console.ReadLine());
    // Console.Write("Укажите кол-во столбов: ");
    // int cols = Convert.ToInt16(Console.ReadLine());

    int[,] array = new int[4, 5];

    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);
    return array;
} 

void Show2DArr(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] FindMin(int[,] array)
{   
    int[] sum = new int[array.GetLength(0)];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[i, j];
        }
        
    }
    return sum;
}

void Show(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

int getMinPos(int[] array)
{
    int min = array[0]; 
    int pos = 0; // Position of min 
 
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            pos = i;
        }
    }
    return pos;
}

int[,] array = Create2dArr();
Show2DArr(array);

int[] points = FindMin(array);
Show(points);
Console.Write($"Номер строки с наименьшей суммой элементов: {getMinPos(points) + 1}");

*/




// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

/*
int[,] Create2dArr()
{
    // Console.WriteLine("Задайте двухмерный массив.");
    // Console.Write("Укажите кол-во строк: ");
    // int rows = Convert.ToInt16(Console.ReadLine());
    // Console.Write("Укажите кол-во столбов: ");
    // int cols = Convert.ToInt16(Console.ReadLine());

    int[,] array = new int[2, 2];

    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);
    return array;
} 

void Show2DArr(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Multiply(int[,] array1, int[,] array2) //Умножение матриц
{
    int[,] multiply = new int[array1.GetLength(0), array1.GetLength(1)]; //Заводим размер матрицы

    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array1.GetLength(1); j++)
        {
            for(int f  = 0; f < array1.GetLength(0) && f < array1.GetLength(1); f++) // При 2х2 будет 2 прохода
            {
                multiply[i, j] += array1[i, f] * array2[f, j]; // При суммировании во втором проходе нужно смещение по разным осям - f++ 
            }
        }
    }
    return multiply;
}   

int[,] array1 = Create2dArr();
int[,] array2 = Create2dArr();

Show2DArr(array1);
Show2DArr(array2);

Show2DArr(Multiply(array1, array2));
*/


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

/*
int[,,] Create3DRandom()
{
    int[,,] array = new int[3, 3, 3];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(1, 31);
            }
        }
    }
    return array;
}

int[,,] Check(int[,,] array)
{   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                for(int ind0 = 0, ind1 = 0, ind2 = 0; ind0 < array.GetLength(0); ind0 ++)
                {
                    if (array[ind0, ind1, ind2] == array[i, j, k]) array[ind0, ind1, ind2] = new Random().Next(1, 31);
                }
            }
        }
    }
    return array;
}

void Show3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{k}({array[i, j, k]}) \t");
            }
            Console.WriteLine();
        }   
        Console.WriteLine();
    }
}

int[,,] NewArray = Create3DRandom();
Show3D(NewArray);

int[,,] UpdateArr = Check(NewArray);
Show3D(UpdateArr);
*/

// Задача 62. Напишите программу, которая заполнит спирально массив A на B.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    int val = 0;
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = val;
            val++;         
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)//rows indexes
    {
        for (int j = 0; j < array.GetLength(1); j++)//columns indexes
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] NewArray = CreateRandom2dArray();
Show2dArray(NewArray);
*/