// Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали 
// с индексами (0,0); (1;1) и т.д.

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод заполняет двумерный массив
int [,] Gen2DArray(int rows, int columns)
{
    int[,] arr = new int[rows, columns];
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            arr[i,j] = i+j;
        }
    }
    return arr;
}

//Метод изменяет двумерный массив
int DiagSum(int [,] arr)
{
    int res=0;
    int min = arr.GetLength(0)>arr.GetLength(1)?arr.GetLength(1):arr.GetLength(0);
    for(int i=0; i<min; i++)
    {
       res=res+arr[i,i];
    }
    return res;
}

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
Console.WriteLine();
int result = DiagSum(arr);
Console.WriteLine(result);