// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input rows ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max: ");
    int max = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min: ");
    int min = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows,columns];
    for(int i = 0; i < rows;i++)
        for(int j = 0; j < columns;j++)
            array[i,j] = new Random().Next(min, max + 1);
        return array;
}

void Show2dArray (int[,]array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
        Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

int[,] MinMaxArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = j + 1; k < array.GetLength(1);k++)
            {
                if (array[i,k] > array[i,j])
                {
                    int temp = array[i,k];
                    array [i,k] = array[i,j];
                    array[i,j] = temp;
                }
            }
        }
    }
    return array;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
int[,] array = MinMaxArray(myArray);
Show2dArray(array);
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input rows ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max: ");
    int max = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min: ");
    int min = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows,columns];
    for(int i = 0; i < rows;i++)
        for(int j = 0; j < columns;j++)
            array[i,j] = new Random().Next(min, max + 1);
        return array;
}

void Show2dArray (int[,]array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
        Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

int[] newArray(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0);i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1);j++)
        {
            sum = sum + array[i,j];
            sumArray[i] = sum;
        }
    }
    return sumArray;
}

void PrintSumArr(int[] array)
{
    Console.Write("Sum: ");
    for (int i = 0;i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine();
}


int ArraySum(int[] array)
{
    int iMin = 0;
    int min = array[iMin];
    for (int i = 1;i < array.Length - 1; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
            iMin = i;
        }
    }
    return iMin;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
int[] sumArray = newArray(myArray);
PrintSumArr(sumArray);
int numRow = (ArraySum(sumArray) + 1);
Console.WriteLine($"{numRow} ");
*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input rows ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max: ");
    int max = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min: ");
    int min = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows,columns];
    for(int i = 0; i < rows;i++)
        for(int j = 0; j < columns;j++)
            array[i,j] = new Random().Next(min, max + 1);
        return array;
}

void Show2dArray (int[,]array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
        Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

int[,] MatrixArray(int[,] array1,int[,]array2)
{
    var newArray = new int[array1.GetLength(0),array2.GetLength(1)];
    if(array1.GetLength(0) !=array2.GetLength(1))
    {
        Console.WriteLine("Eror!!!");
        return null;
    }
    else
    {
        for(int i = 0;i < array1.GetLength(0); i++)
        {
            for(int j = 0;j < array2.GetLength(1);j++)
            {
                newArray[i,j] = 0;
                for(int k = 0; k < array2.GetLength(0); k++)
                {
                    newArray[i,j] += array1[i,k] * array2[k,j];
                }
            }
        }
        return newArray;
    }
}

int[,] array1 = CreateRandom2dArray();
Show2dArray(array1);
int[,] array2 = CreateRandom2dArray();
Show2dArray(array2);
int[,] resultArray = MatrixArray(array1,array2);
Show2dArray(resultArray);
*/

//Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[] NumbersArray()
{
    int[] array = Enumerable.Range(10,90).ToArray();
    for(int i = 0; i< array.Length;i++)
    {
        int j = new Random().Next(0,90);
        if(j !=i)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
    return array;
}

int[,,] CreateRandom3DArray(int[] array,int height,int width,int depth)
{
    int m = 0;
    int[,,] array3d = new int[height,width,depth];
    for( int i = 0;i < height; i++)
    {
        for(int j = 0; j < width;j++)
        {
            for(int k = 0;k < depth; k++)
            {
                array3d[i,j,k] = array[m];
                m++;
            }
        }
    }
    return array3d;
}

void Show3dArray(int[,,] array)
{
    Console.WriteLine("\n (i,j,k) in array: ");
    for(int i = 0;i < array.GetLength(0); i++)
    {
        for(int j = 0;j < array.GetLength(1); j++)
        {
            for(int k = 0;k < array.GetLength(2); k++)
            {
                Console.Write(array[i,j,k] + " ");
                Console.Write($"({i},{j},{k}");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Стоки: ");
int height = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбцы: ");
int width = Convert.ToInt32(Console.ReadLine());
Console.Write("Глубина: ");
int depth = Convert.ToInt32(Console.ReadLine());

int[] myArray = NumbersArray();
int[,,] array3d = CreateRandom3DArray(myArray,height,width,depth);
Show3dArray(array3d);
*/

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] ArraySpiral(int rows, int columns)
{
    int[,] arraySpiral = new int[rows, columns];
    for (int passage = 0, valueElements = 1; valueElements <= rows * columns; passage++)
    {
        for (int i = passage, j = passage; j < columns - passage; j++)
        {
            arraySpiral[i, j] = valueElements;
            valueElements++;
        }
        if(valueElements > rows * columns) break;
        for (int i = passage + 1, j = columns - passage - 1; i < rows - passage; i++)
        {
            arraySpiral[i, j] = valueElements;
            valueElements++;
        }
        if(valueElements > rows * columns) break;
        for (int i = rows - passage - 1, j = columns - passage - 2; j >= passage; j--)
        {
            arraySpiral[i, j] = valueElements;
            valueElements++;
        }
        if(valueElements > rows * columns) break;
        for (int i = rows - passage - 2, j = passage; i > passage; i--)
        {
            arraySpiral[i, j] = valueElements;
            valueElements++;
        }
    }
    return arraySpiral;
}


void PrintArraySpiral(int[,] array, int fillZeros = 2)
{
    Console.WriteLine("\nМассив Спирально: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j].ToString($"D{fillZeros}") + " ");
        Console.WriteLine();
    }
}

Console.Write("Стоки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбцы: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = ArraySpiral(rows,columns);
PrintArraySpiral(myArray);