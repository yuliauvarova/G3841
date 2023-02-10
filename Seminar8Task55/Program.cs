// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае,
// если это невозможно, программа должна вывести
// сообщение для пользователя.

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

//Метод меняет местами строки и столбцы
int[,] TransArray(int[,] arr)
{
    for(int i=0; i<arr.GetLength(0); i++)
    {
        int k=0;
        for(int j=i+1; j<arr.GetLength(1); j++)
        {
            k=arr[i,j];
            arr[i,j]=arr[j,i];
            arr[j,i]=k;
        }
    }
    return arr;
}

bool Test(int[,] arr)
{
    if(arr.GetLength(0)==arr.GetLength(1))
    {
        return true;
    }
    else
    {
        Console.WriteLine("Матрицу перевернуть нельзя");
        return false;
    }
}

int m= ReadData("Введите число строк: ");
int n= ReadData("Введите число столбцов: ");
int[,] arr =Gen2DArray(m,n);
Print2DArray(arr);
Console.WriteLine();
if(Test(arr))
{
    TransArray(arr); //???
    Print2DArray(arr);
}


