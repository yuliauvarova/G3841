// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

double[,] Gen2DArray(int rows, int columns)
{
    double[,] arr = new double [rows,columns];
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            arr[i,j]= new Random().Next(1,100) + new Random().NextDouble();
        }
    }
    return arr;
}

void Print2DArray(double [,] arr)
{
    for(int rows=0; rows<arr.GetLength(0); rows++)
    {
        for(int columns=0; columns<arr.GetLength(1); columns++)
        {
            Console.Write($"{arr[rows,columns]}" +"\t");
        }
    Console.WriteLine();
    }
}


int rows = ReadData("Введите число строк: ");
int columns = ReadData("Введите число столбцов: ");

double[,] array = Gen2DArray(rows,columns);
Print2DArray(array);