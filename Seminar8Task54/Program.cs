// Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.

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

//Метод сортировки одномерного массива пузырьком
void BubbleSort(int[] arr)
{
    int j=0;
    for(int k=0; k<arr.Length; k++)
    {
            for(int i=0; i<arr.Length-1; i++)
        {
            j=i+1;
            if(arr[i]>arr[j])
            {
                int temporary =arr[i];
                arr[i]=arr[j];
                arr[j]=temporary;
            }
        }
    }
}

//Метод упорядочивает по убыванию все элементы каждой строки
void OrderLineElements(int[,] arr)
{
    for(int p=0; p<arr.GetLength(0); p++)
    {
        int [] newArrLine = new int[arr.GetLength(0)];
        
        for(int l=0; l<arr.GetLength(1); l++)
        {
            newArrLine[l]= arr[p,l];
        }
        BubbleSort(newArrLine);
         for(int l=0; l<arr.GetLength(1); l++)
        {
            arr[p,arr.GetLength(1)-1-l]= newArrLine[l];
        }
    }
}

int m= ReadData("Введите число строк: ");
int n= ReadData("Введите число столбцов: ");
int[,] arr =Gen2DArray(m,n);
Print2DArray(arr);
Console.WriteLine();
OrderLineElements(arr);
Print2DArray(arr);