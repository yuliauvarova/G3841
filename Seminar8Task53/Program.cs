// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю
// строку массива.

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

//Метод меняет местами первую и последнюю строки
void SwapRows2DArray(int[,] arr)
{
    int temp =0;

    for(int i=0; i<arr.GetLength(1); i++)
    {
        temp = arr[0,i];
        arr[0,i]=arr[arr.GetLength(0)-1,i];
        arr[arr.GetLength(0)-1,i]=temp;
    }
}

int m= ReadData("Введите число строк: ");
int n= ReadData("Введите число столбцов: ");
int[,] arr =Gen2DArray(m,n);
Print2DArray(arr);
Console.WriteLine();
SwapRows2DArray(arr);
Print2DArray(arr);
