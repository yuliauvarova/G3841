// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце.

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод генерирует двумерный массив
int[,] Gen2DArray(int rows, int columns)
{
    int[,] arr = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = new Random().Next(1, 1000);
        }
    }
    return arr;
}

//Метод выводит двумерный массив на экран
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

//Метод подсчитывает среднее арифметическое элементов в каждом столбце
int[] MidSumColumns(int[,] arr)
{
    int[] result = new int[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            result[j] = (result[j] + arr[i, j]);
        }
        result[j] = result[j] / arr.GetLength(1);
    }
    return result;
}

//Метод выводит на экран массив
void Print1DArray(int[] arr)
{
    for(int i = 0; i<arr.Length; i++)
    {
        Console.Write(arr[i] + "\t");
    }
}

int rows = ReadData("Введите число строк: ");
int columns = ReadData("Введите число столбцов: ");
int[,] arr = Gen2DArray(rows, columns);
Print2DArray(arr);
int[] result = MidSumColumns(arr);
Console.WriteLine();
Print1DArray(result);