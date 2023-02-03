// Задайте двумерный массив размером m x n, 
// заполненный случайными целыми числами.

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод заполняет матрицу случайными числами
int [,] Gen2DArray(int rows, int columns)
{
    int[,] arr = new int[rows, columns];
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            arr[i,j] = new Random().Next(0,1000);
        }
    }
    return arr;
}

//Метод выводит на экран двумерный массив
void Print2DArray(int[,] arr)
{
    for(int rows = 0; rows<arr.GetLength(0); rows++)
    {
        for(int columns=0; columns<arr.GetLength(1); columns++)
        {
            Console.Write($"{arr[rows, columns]} ");
        }
    Console.WriteLine();
    }
}

int rows = ReadData("Введите число строк: ");
int columns = ReadData("Введите число столбцов: ");
int [,] arr = Gen2DArray(rows, columns);
Print2DArray(arr);

