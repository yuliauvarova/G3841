// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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
            arr[i, j] = new Random().Next(1, 10);
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

//Метод ищет строку с наименьшей суммой элементов
int SearchMinSumLine(int[,] arr)
{

    int minLine = 0;
    int min = int.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        if (sum < min)
        {
            min = sum;
            minLine = i;
        }
    }
    return minLine;
}

//Метод выводит на экран одну строку массива
void PrintLine(int[,] arr, int Line)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[Line, j] + "\t");
    }
}



int rows = ReadData("Введите число строк: ");
int columns = ReadData("Введите число столбцов: ");

if (rows != columns)
{
    int[,] arr = Gen2DArray(rows, columns);
    Print2DArray(arr);
    Console.WriteLine();
    int minLine = SearchMinSumLine(arr);
    PrintLine(arr,minLine);

}
else
{
    Console.WriteLine("С этими значениями невозможно построить прямоугольный массив.");
}

