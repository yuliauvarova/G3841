// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и
// столбец, на пересечении которых расположен
// наименьший элемент массива.

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

//Метод поиска минимального элемента
(int x, int y) SearchMinElement(int[,] arr)
{
    int row =0;
    int col =0;
    int minElem = int.MaxValue;
    for(int i=0; i< arr.GetLength(0); i++)
    {
        for(int j=0; j< arr.GetLength(1); j++)
        {
            if(minElem>arr[i,j])
            {
                row=i;
                col =j;
                minElem = arr[i,j];
            }
        }
    }
    return (row,col);
}

//Метод сокращает массив 
int [,] Update2DArray(int[,] arr, int x, int y)
{
    int k = 0;
    //int l=0;
    int[,] resArr = new int[arr.GetLength(0)-1,arr.GetLength(1)-1];
    for(int i = 0; i<arr.GetLength(0)-1; i++)
    {
       int l=0;
        for(int j = 0; j<arr.GetLength(1)-1; j++)
        {
            if(i!=x && j!=y)
            {
                resArr[i,j]= arr[k,l];
            }
            if(j!=y){l++;}
        }
        if(i!=x){k++;}
    }
    return resArr;
}

int m= ReadData("Введите число строк: ");
int n= ReadData("Введите число столбцов: ");
int[,] arr =Gen2DArray(m,n);
Print2DArray(arr);
Console.WriteLine();
(int x, int y) minElem = SearchMinElement(arr);
int[,] newArr = Update2DArray(arr,minElem.x,minElem.y);
Print2DArray(newArr);